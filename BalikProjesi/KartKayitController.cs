using BalikProjesi.Entities;
using BalikProjesi.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalikProjesi.Enums;
using MongoDB.Driver;
using System.Collections;

namespace BalikProjesi
{
    public partial class KartKayitController : UserControl
    {
        private readonly ICartsServices1 _cartService;
        private string CardID = String.Empty;
        private readonly ReaderServices _readerServices;
        private readonly IPersonelServices _personelService;
        private readonly IFishBoxServices _fboxService;
        private readonly IRecordingsServices _recordingsService;
        private long CardCount;
        private int currentPage;
        private long lastPage;

        private bool NewRecord = true;
        public KartKayitController()
        {
            InitializeComponent();
            _recordingsService = new RecordingsServices();
            _cartService = new CartsServices();
            _readerServices = new ReaderServices();
            CardID = String.Empty;
            _personelService = new PersonelServices();
            _fboxService = new FishBoxServices();
            cbCardType.Items.Add(InputEnums.Kasa);
            cbCardType.Items.Add(InputEnums.Fileto);
            cbCardType.Items.Add(InputEnums.Kontrol);
            cbCardType.SelectedIndex = 1;
            CardCount = _cartService.GetDocumentCount();
            currentPage = 1;
            lastPage = DivideRoundingUp(CardCount, 15);
            lbPagination.Text = currentPage + "/" + lastPage;

            int maxWidthSize = Screen.PrimaryScreen.Bounds.Width;
            listView1.MaximumSize = new Size(maxWidthSize - 10, 282);
            listView1.MaximumSize = new Size(0, 282);

            lbDocumentCount.Text = InputEnums.ToplamKayıt + CardCount;
        }

        
        public void liste()
        {
            
            string CartAd, CartCode, CartType, CartUUID;
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }
            var dt = _cartService.Get(currentPage);
            foreach (var item in dt)
            {
                CartAd = item.CartName;
                CartCode = item.CartCode;
                CartType = item.CartType;
                CartUUID = item.Id;

                string[] data = { CartAd, CartCode, CartType, CartUUID };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
            KartKoduTb.Clear();
            cbCardType.SelectedIndex = 0;
            CardID = "";
            AddOrUpdateBtn.Text = "KAYDET";
        }

        private int _sortColumnIndex = -1;
        private void columnSort_Click(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != _sortColumnIndex)
            {
                
                _sortColumnIndex = e.Column;
                
                listView1.Sorting = SortOrder.Ascending;
            }
            else
            {
                
                if (listView1.Sorting == SortOrder.Ascending)
                    listView1.Sorting = SortOrder.Descending;
                else
                    listView1.Sorting = SortOrder.Ascending;
            }

            
            listView1.Sort();

            

            listView1.ListViewItemSorter = new ListViewItemStringComparer(e.Column, listView1.Sorting);

        }

        #region FIXED METHODS

        private void BtnTextChanger(bool RecordType)
        {
            NewRecord = RecordType;
            if (RecordType)
            {
                AddOrUpdateBtn.Text = "KAYDET";
                CardID = string.Empty;
            }
            else
            {
                AddOrUpdateBtn.Text = "GÜNCELLE";
            }
        }
        private void Create()
        {
            BtnTextChanger(true);
            if (string.IsNullOrEmpty(KartKoduTb.Text.Trim()))
            {
                lbCardCode.Text = WarningEnums.ThisFieldMustBeFilled;
                KartKoduTb.Focus();
            }
            else
            {
                var result = _cartService.Create(new Carts
                {
                    CartCode = KartKoduTb.Text.Trim(),
                    CartType = cbCardType.Text,
                    CreateDate = DateTime.Now
                });
                if (result)
                {
                    MessageBox.Show(WarningEnums.CreateSuccess);
                    CardCount++;
                    lbDocumentCount.Text = InputEnums.ToplamKayıt + CardCount;
                }
                else
                {
                    MessageBox.Show(WarningEnums.CardIsDefined);
                    lbCardCode.Text = "";
                }
                liste();
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                BtnTextChanger(false);

                ListViewItem itm = listView1.SelectedItems[0];
                CardID = itm.SubItems[3].Text;
                KartKoduTb.Text = itm.SubItems[1].Text;

                if (itm.SubItems[2].Text == InputEnums.Kasa)
                    cbCardType.SelectedIndex = 0;
                else if (itm.SubItems[2].Text == InputEnums.Fileto)
                    cbCardType.SelectedIndex = 1;
                else if (itm.SubItems[2].Text == InputEnums.Kontrol)
                    cbCardType.SelectedIndex = 2;
            }
        }
        private void TemizleBtnClick(object sender, EventArgs e)
        {
            BtnTextChanger(true);
            liste();
            lbCardCode.Text = String.Empty;
        }

        private void AddorUpdateBtn_Click(object sender, EventArgs e)
        {
            if (NewRecord)
            {
                Create();
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(WarningEnums.AskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    KayitGuncelle();
                }
            }
        }

        public void KayitGuncelle()
        {
            string OldCardCode = string.Empty;
            string NewCardCode = string.Empty;
            string NewCartType = string.Empty;
            if (!string.IsNullOrEmpty(KartKoduTb.Text.Trim()))
            {
                NewCardCode = KartKoduTb.Text.Trim();
                NewCartType = cbCardType.Text.Trim(); 
                var OldCard = _cartService.GetByCardID(CardID);
                OldCardCode = OldCard.CartCode;


                OldCard.CartCode = NewCardCode;
                OldCard.CartType = NewCartType;
                var UpdateStatus = _cartService.Update(OldCard);
                if (UpdateStatus)
                {
                    var PersonelUpdate = _personelService.ChangeCardId(OldCardCode, NewCardCode);
                    if (!PersonelUpdate)
                    {
                        MessageBox.Show("Personel Kart Güncelleme Hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var FishboxUpdate = _fboxService.UpdateCartId(OldCardCode, NewCardCode);
                    if (!FishboxUpdate)
                    {
                        MessageBox.Show("Kasa Kart Güncelleme Hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var RecordingUpdate = _recordingsService.ChangeCardId(OldCardCode, NewCardCode);
                    if (!RecordingUpdate)
                    {
                        MessageBox.Show("Kayıt Kart Güncelleme Hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            BtnTextChanger(true);
            liste();
            lbCardCode.Text = String.Empty;
        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                currentPage--;
                lbPagination.Text = currentPage + "/" + lastPage;
                liste();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage != lastPage)
            {
                currentPage++;
                lbPagination.Text = currentPage + "/" + lastPage;
                liste();
            }
        }

        public static long DivideRoundingUp(long x, long y)
        {
            long s;

            if (x > y)
            {
                long a = x % y;
                x -= a;

                if (a != 0)
                    s = (x / y) + 1;
                else
                    s = (x / y);

                return s;
            }
            else
            {
                return 1;
            }
        }

        #endregion








        public void listget(Carts card = null)
        {
            if (card != null)
            {
                AddOrUpdateBtn.Text = "GÜNCELLE";
                KartKoduTb.Text = card.CartCode;

                if (card.CartType == InputEnums.Kasa)
                    cbCardType.SelectedIndex = 0;
                else if (card.CartType == InputEnums.Fileto)
                    cbCardType.SelectedIndex = 1;
                else if (card.CartType == InputEnums.Kontrol)
                    cbCardType.SelectedIndex = 2;

                CardID = card.Id;
            }
            else
            {
                AddOrUpdateBtn.Text = "GÜNCELLE";
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem itm = listView1.SelectedItems[0];
                    CardID = itm.SubItems[3].Text;
                    KartKoduTb.Text = itm.SubItems[1].Text;

                    if (itm.SubItems[2].Text == InputEnums.Kasa)
                        cbCardType.SelectedIndex = 0;
                    else if (itm.SubItems[2].Text == InputEnums.Fileto)
                        cbCardType.SelectedIndex = 1;
                    else if (itm.SubItems[2].Text == InputEnums.Kontrol)
                        cbCardType.SelectedIndex = 2;

                    


                }
            }
        }
       




        

        private void KartKayitController_Load(object sender, EventArgs e)
        {
            liste();

        }
     
        


        private void DeleteMenuStrip_Click(object sender, EventArgs e)
        {
            ////Kartı güncellerken diğer kayıtlara da bakıp oradan işilişiğini kesmemiz gerekiyor.
            //string CartCode = KartKoduTb.Text.Trim();
            //string CartType = cbCardType.Text.Trim();
            //void onlyDelete()//Kartın eşleşen bir kaydı yoksa bu kısım çalışıyor.
            //{
            //    var result = _cartService.Delete(CardID);
            //    if (result)
            //    {
            //        MessageBox.Show(WarningEnums.DeleteSuccess);
            //        CardCount--;
            //        lbDocumentCount.Text = InputEnums.ToplamKayıt + CardCount;
            //    }
            //    else
            //    {
            //        MessageBox.Show(WarningEnums.DeleteFailed);
            //    }
            //}
            //if (!string.IsNullOrEmpty(CardID))//bu kısımda karta ait veriler olup olmadığını kontrol ediyoruz
            //{
            //    //Veri kaybı için bilgilendirme
            //    if (MessageBox.Show(WarningEnums.DataLoss, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        //Veri kaybı için bilgilendirme
            //        if (MessageBox.Show(WarningEnums.DataLossConfirm, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        {
            //            //Okunan kartın bilgilerini getiriyoruz
            //            var chkcard = _cartService.GetByCardID(CardID);
            //            if (chkcard != null)
            //            {
                            
            //                var chkfb = _fboxService.GetByCardCode(CardID);
            //                var chkfillet = _personelService.GetFilletPersonnelByCardId(CardID);
            //                var chkkontrol = _personelService.GetControlPersonnelByCardId(CardID);
            //                //Okunan kartı her bir collectionda sorguluyoruz ve eşleşen kayıttaki kart bilgilerini siliyoruz.eğer bulunmaz ise sadece kartı siliyoruz.
            //                void updatecardinfo()
            //                {
            //                    if (chkfb != null)
            //                    {
            //                        chkfb.CartId = "";
            //                        chkfb.CartCode = "";
            //                        if (MessageBox.Show(WarningEnums.CardMatchedAnotherRecord + WarningEnums.Space + WarningEnums.CardMatchedAnotherRecordAskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //                        {
            //                            var result = _fboxService.UpdateCardInfo(chkfb);
            //                            if (result)
            //                            {
            //                                onlyDelete();
            //                                MessageBox.Show(WarningEnums.MacthedRecordUpdateSuccess);
            //                            }
            //                        }

            //                    }
            //                    else if (chkfillet != null)
            //                    {
            //                        if (MessageBox.Show(WarningEnums.CardMatchedAnotherRecord + WarningEnums.Space + WarningEnums.CardMatchedAnotherRecordAskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //                        {
            //                            chkfillet.CartId = "";
            //                            chkfillet.CartCode = "";
            //                            var result = _personelService.UpdateFilletCardInfo(chkfillet);
            //                            if (result)
            //                            {
            //                                onlyDelete();
            //                                MessageBox.Show(WarningEnums.MacthedRecordUpdateSuccess);
            //                            }
            //                        }
            //                    }
            //                    else if (chkkontrol != null)
            //                    {
            //                        if (MessageBox.Show(WarningEnums.CardMatchedAnotherRecord + WarningEnums.Space + WarningEnums.CardMatchedAnotherRecordAskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //                        {
            //                            chkkontrol.CartId = "";
            //                            chkkontrol.CartCode = "";
            //                            var result = _personelService.UpdateControllerCardInfo(chkkontrol);
            //                            if (result)
            //                            {
            //                                onlyDelete();
            //                                MessageBox.Show(WarningEnums.MacthedRecordUpdateSuccess);
            //                            }
            //                        }
            //                    }
            //                    else
            //                    {
            //                        onlyDelete();
            //                    }
            //                }
            //                if (CartType == InputEnums.Kontrol)
            //                {
            //                    updatecardinfo();
            //                }
            //                else if (CartType == InputEnums.Fileto)
            //                {
            //                    updatecardinfo();
            //                }
            //                else if (CartType == InputEnums.Kasa)
            //                {
            //                    updatecardinfo();
            //                }

            //            }
            //            else
            //            {
            //                onlyDelete();
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    //MessageBox.Show(WarningEnums.InvalidSelection);
            //}

            
            
            liste();
           }

        private async void bntCardReader_Click(object sender, EventArgs e)
        {
            await _readerServices.WriteTagIdToTextboxAsync(KartKoduTb); 
        }
        void listwidth()
        {
            int width = this.Width;

            try
            {
                for (int i = 0; i < listView1.Columns.Count - 1; i++)
                {

                    switch (i)
                    {
                        case 0:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.25);
                            break;
                        case 1:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.5);
                            break;
                        case 2:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.25);
                            break;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void KartKayitController_SizeChanged(object sender, EventArgs e)
        {

            listwidth();
        }

        private void rbCardNo_CheckedChanged(object sender, EventArgs e)
        {
            tbSearch.Focus();
        }

        private void rbCardType_CheckedChanged(object sender, EventArgs e)
        {
            tbSearch.Focus();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            List<Carts> FilteredCards;
            var Filter = FilterDefinition<Carts>.Empty;

            if (rbCardNo.Checked)
            {
                Filter = Builders<Carts>.Filter.Regex(x => x.CartName, new MongoDB.Bson.BsonRegularExpression(search, "i"));
            }
            if (rbCardType.Checked)
            {
                Filter = Builders<Carts>.Filter.Regex(x => x.CartType, new MongoDB.Bson.BsonRegularExpression(search, "i"));
            }

            FilteredCards = _cartService.GetFilteredCards(Filter);
            if (FilteredCards != null)
            {
                PageFilteredCardsToTable(FilteredCards);
            }
        }

        public void PageFilteredCardsToTable(List<Carts> tableList)
        {
            string CartAd, CartCode, CartType, CartUUID;
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }

            foreach (var item in tableList)
            {
                CartAd = item.CartName;
                CartCode = item.CartCode;
                CartType = item.CartType;
                CartUUID = item.Id;

                string[] data = { CartAd, CartCode, CartType, CartUUID };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
        }

        

      



        #region Gereksiz METHODLAR

        public void dataupdate()
        {

            string CartCode = KartKoduTb.Text.Trim();
            string CartType = cbCardType.Text.Trim();
            void updateOnlyCard()//Kart güncellemesi
            {
                Entities.Carts ct = new Carts();
                ct.CartCode = CartCode;
                ct.CartType = CartType;
                ct.Id = CardID;
                ct.UpdateDate = DateTime.Now;
                bool chk = _cartService.Update(ct);
                if (chk == true)
                {
                    MessageBox.Show(WarningEnums.UpdateSuccess);
                }
                else
                {
                    MessageBox.Show(WarningEnums.UpdateFailed);
                }
            }

            //Kart seçildise veya okunduysa çalışır
            if (!string.IsNullOrEmpty(CardID))
            {
                //Veri kaybı için bilgilendirme
                if (MessageBox.Show(WarningEnums.DataLoss, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Veri kaybı için bilgilendirme
                    if (MessageBox.Show(WarningEnums.DataLossConfirm, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Okunan kartın bilgilerini getiriyoruz
                        var chkcard = _cartService.GetByCardID(CardID);
                        if (chkcard != null)
                        {
                            //Okunan kartı her bir collectionda sorguluyoruz
                            var chkfb = _fboxService.GetByCardCode(CardID);
                            var chkfillet = _personelService.GetFilletPersonnelByCardId(CardID);
                            var chkkontrol = _personelService.GetControlPersonnelByCardId(CardID);
                            //okunan kart hangi collectiondaysa o kısmı güncelliyoruz
                            void updatecardinfo()//Okunan kartı her bir collectionda sorguluyoruz ve eşleşen kayıttaki kart bilgilerini siliyoruz.eğer bulunmaz ise sadece kartı siliyoruz.
                            {
                                if (chkfb != null)
                                {
                                    if (MessageBox.Show(WarningEnums.CardMatchedAnotherRecord + WarningEnums.Space + WarningEnums.CardMatchedAnotherRecordAskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        chkfb.CartId = "";
                                        chkfb.CartCode = "";
                                        var result = _fboxService.UpdateCardInfo(chkfb);
                                        if (result)
                                        {
                                            updateOnlyCard();
                                            MessageBox.Show(WarningEnums.MacthedRecordUpdateSuccess);
                                        }
                                    }
                                    else
                                    {
                                        updateOnlyCard();
                                    }

                                }
                                else if (chkfillet != null)
                                {
                                    if (MessageBox.Show(WarningEnums.CardMatchedAnotherRecord + WarningEnums.Space + WarningEnums.CardMatchedAnotherRecordAskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        chkfillet.CartId = "";
                                        chkfillet.CartCode = "";
                                        var result = _personelService.UpdateFilletCardInfo(chkfillet);
                                        if (result)
                                        {
                                            updateOnlyCard();
                                            MessageBox.Show(WarningEnums.MacthedRecordUpdateSuccess);
                                        }

                                    }
                                }
                                else if (chkkontrol != null)
                                {
                                    if (MessageBox.Show(WarningEnums.CardMatchedAnotherRecord + WarningEnums.Space + WarningEnums.CardMatchedAnotherRecordAskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        chkkontrol.CartId = "";
                                        chkkontrol.CartCode = "";
                                        var result = _personelService.UpdateControllerCardInfo(chkkontrol);
                                        if (result)
                                        {
                                            updateOnlyCard();
                                            MessageBox.Show(WarningEnums.MacthedRecordUpdateSuccess);
                                        }
                                    }
                                }
                                else
                                {
                                    updateOnlyCard();
                                }
                            }
                            if (CartType == InputEnums.Kontrol)
                            {
                                updatecardinfo();
                            }
                            else if (CartType == InputEnums.Fileto)
                            {
                                updatecardinfo();
                            }
                            else if (CartType == InputEnums.Kasa)
                            {
                                updatecardinfo();
                            }

                        }
                        else
                        {
                            updateOnlyCard();
                        }
                    }
                }
            }
            else
            {

            }
            liste();


        }

        private void KartKoduTb_TextChanged(object sender, EventArgs e)
        {

            string cardcodetxt = KartKoduTb.Text.Trim();
            var readCard = _cartService.GetByCardCode(cardcodetxt);

            if (readCard != null)
            {
                listget(readCard);
            }
            else
            {
                cbCardType.SelectedIndex = 0;
                AddOrUpdateBtn.Text = "KAYDET";
            }

            lbCardCode.Text = "";
        }
        #endregion
       
    }
    class ListViewItemStringComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemStringComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemStringComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                       ((ListViewItem)y).SubItems[col].Text);


            if (order == SortOrder.Descending)

                returnVal *= -1;

            return returnVal;
        }
    }
}

