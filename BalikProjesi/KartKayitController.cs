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

namespace BalikProjesi
{
    public partial class KartKayitController : UserControl
    {
        private readonly ICartsServices1 _cartService;
        private string CardID = "";
        private readonly ReaderServices _readerServices;
        private readonly IPersonelServices _personelService;
        private readonly IFishBoxServices _fboxService;
        private long CardCount;
        private int currentPage;
        private long lastPage;

        public KartKayitController()
        {
            InitializeComponent();
            _cartService = new CartsServices();
            _readerServices = new ReaderServices();
            CardID = "";
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
            if (listView1.Items.Count != 0)
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
            button1.Text = "KAYDET";
        }
        public void listget(Carts card = null)
        {
            if (card != null)
            {
                button1.Text = "GÜNCELLE";
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
                button1.Text = "GÜNCELLE";
                if (listView1.SelectedItems.Count != 0)
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
                            if (CartType==InputEnums.Kontrol)
                            {
                                updatecardinfo();
                            }
                            else if (CartType==InputEnums.Fileto)
                            {
                                updatecardinfo();
                            }
                            else if (CartType==InputEnums.Kasa)
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
        void Create()
        {
            bool check = true;
            if (string.IsNullOrEmpty(KartKoduTb.Text))
            {
                lbCardCode.Text = WarningEnums.ThisFieldMustBeFilled;
                KartKoduTb.Focus();
                check = false;
            }
            if (check)
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




        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="KAYDET")
            {
                Create();

            }
            else if(button1.Text=="GÜNCELLE")
            {
                if (MessageBox.Show(WarningEnums.AskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataupdate();
                    liste();
                }
                else
                {
                    liste();
                }
                
            }

        }

        private void KartKayitController_Load(object sender, EventArgs e)
        {
            liste();

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listget();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataupdate();
            liste();
            lbCardCode.Text = "";

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            listget();
        }

        private void KartKayitController_Load_1(object sender, EventArgs e)
        {
            liste();
        }

        private void DeleteMenuStrip_Click(object sender, EventArgs e)
        {
            //Kartı güncellerken diğer kayıtlara da bakıp oradan işilişiğini kesmemiz gerekiyor.
            string CartCode = KartKoduTb.Text.Trim();
            string CartType = cbCardType.Text.Trim();
            void onlyDelete()//Kartın eşleşen bir kaydı yoksa bu kısım çalışıyor.
            {
                var result = _cartService.Delete(CardID);
                if (result)
                {
                    MessageBox.Show(WarningEnums.DeleteSuccess);
                    CardCount--;
                    lbDocumentCount.Text = InputEnums.ToplamKayıt + CardCount;
                }
                else
                {
                    MessageBox.Show(WarningEnums.DeleteFailed);
                }
            }
            if (!string.IsNullOrEmpty(CardID))//bu kısımda karta ait veriler olup olmadığını kontrol ediyoruz
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
                            
                            var chkfb = _fboxService.GetByCardCode(CardID);
                            var chkfillet = _personelService.GetFilletPersonnelByCardId(CardID);
                            var chkkontrol = _personelService.GetControlPersonnelByCardId(CardID);
                            //Okunan kartı her bir collectionda sorguluyoruz ve eşleşen kayıttaki kart bilgilerini siliyoruz.eğer bulunmaz ise sadece kartı siliyoruz.
                            void updatecardinfo()
                            {
                                if (chkfb != null)
                                {
                                    chkfb.CartId = "";
                                    chkfb.CartCode = "";
                                    if (MessageBox.Show(WarningEnums.CardMatchedAnotherRecord + WarningEnums.Space + WarningEnums.CardMatchedAnotherRecordAskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        var result = _fboxService.UpdateCardInfo(chkfb);
                                        if (result)
                                        {
                                            onlyDelete();
                                            MessageBox.Show(WarningEnums.MacthedRecordUpdateSuccess);
                                        }
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
                                            onlyDelete();
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
                                            onlyDelete();
                                            MessageBox.Show(WarningEnums.MacthedRecordUpdateSuccess);
                                        }
                                    }
                                }
                                else
                                {
                                    onlyDelete();
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
                            onlyDelete();
                        }
                    }
                }
            }
            else
            {
                //MessageBox.Show(WarningEnums.InvalidSelection);
            }

            
            
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
            if (listView1.Items.Count != 0)
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
                button1.Text = "KAYDET";
            }

            lbCardCode.Text = "";
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

    }
}

