using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalikProjesi.Entities;
using BalikProjesi.Enums;
using BalikProjesi.Services;
using MongoDB.Driver;

namespace BalikProjesi
{
    public partial class KasaKayitController : UserControl
    {

        private readonly IFishBoxServices _fboxService;
        private readonly IRecordingsServices _recordingsService;
        private readonly ReaderServices _readerServices;
        private readonly ICartsServices1 _cartServices;
        private long BoxCount;
        private int currentPage;
        private long lastPage;

        private string BoxID;
        private string CardID;
        private bool NewRecord = true; 
        public KasaKayitController()
        {
            InitializeComponent();
            _recordingsService = new RecordingsServices();
            _fboxService = new FishBoxServices();
            _readerServices = new ReaderServices();
            _cartServices = new CartsServices();
            BoxID = "";
            CardID = "";
            BoxCount = _fboxService.GetDocumentCount();
            currentPage = 1;
            lastPage = DivideRoundingUp(BoxCount, 15);
            lbPagination.Text = currentPage + "/" + lastPage;

            int maxWidthSize = Screen.PrimaryScreen.Bounds.Width;
            listView1.MaximumSize = new Size(maxWidthSize-10, 282);
            listView1.MaximumSize = new Size(0, 282);

            lbDocumentCount.Text = InputEnums.ToplamKayıt + BoxCount;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //public void dataupdate()
        //{

        //    string boxcode = txtKasakod.Text.Trim();
        //    string CartCode =txtKartid.Text.Trim();
        //    string boxtype = txtKasatip.Text.Trim();
        //    var readCard = _cartServices.GetByCardCode(CartCode);
        //    if (readCard != null)
        //    {
        //        CardID = readCard.Id;                
        //    }
        //    else
        //    {
        //        MessageBox.Show(WarningEnums.DefineToCardCollection);
        //    }
        //    if (!string.IsNullOrEmpty(BoxID)&& readCard != null)
        //    {
        //        if (readCard.CartType==InputEnums.Kasa)
        //        {
        //            Entities.FishBox fb = new FishBox();


        //            fb.FishBoxCode = boxcode;
        //            fb.CartCode = CartCode;
        //            fb.CartId = CardID;
        //            fb.FishBoxType = boxtype;
        //            fb.Id = BoxID;
        //            fb.UpdateDate = DateTime.Now;
        //            bool chk = _fboxService.Update(fb);
        //            if (chk == true)
        //            {
        //                MessageBox.Show(WarningEnums.UpdateSuccess);
        //            }
        //            else
        //            {
        //                MessageBox.Show(WarningEnums.UpdateFailed);
        //            }
        //        }
        //        else if (readCard.CartType == InputEnums.Fileto)
        //        {
        //            MessageBox.Show("Okunan kart Fileto personeli kartıdır. Lüften farklı bir kartla tekrar deneyin veya kartı güncelleyin.");
        //        }
        //        else if (readCard.CartType == InputEnums.Kontrol)
        //        {
        //            MessageBox.Show("Okunan kart Kontrol personeli kartıdır. Lüften farklı bir kartla tekrar deneyin veya kartı güncelleyin.");
        //        }



        //    }
        //    else if(string.IsNullOrEmpty(BoxID))
        //    {
        //        MessageBox.Show("Lütfen listeden güncellemek istediğiniz kaydı seçiniz veya kartınızı okutunuz");
        //    }
        //    list();


        //}

        private void button1_Click(object sender, EventArgs e)
        {
            list();
            BtnTextChanger(true);
        }
        void create()
        {
            bool check = true;
            if (string.IsNullOrEmpty(txtKartid.Text) || string.IsNullOrEmpty(txtKasakod.Text) || string.IsNullOrEmpty(txtKasatip.Text))
            {
                if (string.IsNullOrEmpty(txtKartid.Text))
                {
                    MessageBox.Show(WarningEnums.InvalidSelection, WarningEnums.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    check = false;
                }
                if (string.IsNullOrEmpty(txtKasakod.Text))
                {
                    MessageBox.Show(WarningEnums.FishboxCodeIsEmpty, WarningEnums.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    check = false;
                }
                if (string.IsNullOrEmpty(txtKasatip.Text))
                {
                    MessageBox.Show(WarningEnums.FishboxTypeIsEmpty, WarningEnums.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    check = false;
                }
            }
            else
            {
                string cardCode = txtKartid.Text.Trim();


                var readCard = _cartServices.GetByCardCode(cardCode);
                if (readCard != null)
                {
                    CardID = readCard.Id;
                    if (check)
                    {

                        if (readCard.CartType == InputEnums.Kasa)
                        {
                            var kasaresult = _fboxService.Create(new FishBox
                            {
                                CreateDate = DateTime.Now,
                                FishBoxCode = txtKasakod.Text.Trim(),
                                FishBoxType = txtKasatip.Text.Trim(),
                                CartCode = cardCode,
                                CartId = CardID
                            });
                            switch (kasaresult)
                            {
                                case true:
                                    MessageBox.Show(WarningEnums.CreateSuccess);
                                    BoxCount++;
                                    lbDocumentCount.Text = InputEnums.ToplamKayıt + BoxCount;

                                    break;
                                case false:
                                    MessageBox.Show(WarningEnums.CreateFailed);
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Okunan kart " + readCard.CartType + " kartıdır. Kaydı yapabilmeniz için " + InputEnums.Kasa + " tipinde bir kart gerekmektedir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }

                    }
                    var result = _fboxService.GetByCardCode(CardID);
                    if (result.CartType == InputEnums.Kontrol)
                    {
                        MessageBox.Show("Okunan kart " + result.CartType + " kartıdır. Lütfen başka bir kart giriniz veya kartı güncelleyiniz");
                    }
                    else if (result.CartType == InputEnums.Fileto)
                    {
                        MessageBox.Show("Okunan kart " + result.CartType + " kartıdır. Lütfen başka bir kart giriniz veya kartı güncelleyiniz");
                    }
                }
                else
                {
                    MessageBox.Show(WarningEnums.InvalidSelection);
                }
               

                CardID = "";
            }
            
            list();
        }
        private void AddorUpdateBtnClick(object sender, EventArgs e)
        {
            
            if (NewRecord)
            {
                create();
            }
            else
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show(WarningEnums.AskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                   // KayitGuncelle();
                }
                
            }
        }
        public void PageFilteredFishBoxToTable(List<FishBox> tableList)
        {
            if (listView1.Items.Count != 0)
            {
                listView1.Items.Clear();
            }

            string boxcode, boxtype, boxcardid;

            foreach (var item in tableList)
            {
                boxcode = item.FishBoxCode;
                boxtype = item.FishBoxType;
                boxcardid = item.CartCode;
                string[] data = { boxcode, boxtype, boxcardid };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
        }
        public void list()
        {

            string BoxCode, BoxType, BoxcardId;
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }
            var dt = _fboxService.Get(currentPage);
            foreach (var item in dt)
            {
                BoxCode = item.FishBoxCode;
                BoxType = item.FishBoxType;
                BoxcardId = item.CartCode;
                BoxID = item.Id;
                string[] data = { BoxCode, BoxType, BoxcardId, BoxID };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
            txtKartid.Clear();
            txtKasakod.Clear();
            txtKasatip.Clear();
            BoxID = "";
            CardID = "";
            AddorUpdateBtn.Text = "KAYDET";
        }

        //void list()
        //{
        //    listView1.Items.Clear();
        //    string boxcode, boxtype, boxcardid;
        //    var dt = _fboxService.Get(currentPage);
        //    foreach (var item in dt)
        //    {
        //        boxcode = item.FishBoxCode;
        //        boxtype = item.FishBoxType;
        //        boxcardid = item.CartCode;                
        //        BoxID = item.Id;
        //        string[] data = { boxcode, boxtype, boxcardid, BoxID };
        //        ListViewItem record = new ListViewItem(data);
        //        listView1.Items.Add(record);
        //    }            
        //    txtKartid.Clear();
        //    txtKasakod.Clear();
        //    txtKasatip.Clear();
        //    BoxID = "";
        //    CardID = "";
        //    AddorUpdateBtn.Text = "KAYDET";//button text-kaydet
        //}
        void listget(Carts card=null)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                txtKasakod.Text = itm.SubItems[0].Text;
                txtKasatip.Text = itm.SubItems[1].Text;
                BoxID = itm.SubItems[3].Text;
                txtKartid.Text = itm.SubItems[2].Text;


            }

            ////button2.Text = "GÜNCELLE";//button text-güncelle
            //if (card!=null)
            //{
            //    var fb = _fboxService.GetByCardCode(card.Id);
            //    if (fb!=null)
            //    {
            //        txtKasakod.Text = fb.FishBoxCode;
            //        txtKasatip.Text = fb.FishBoxType;
            //        txtKartid.Text = fb.CartCode;
            //        BoxID = fb.Id;
            //        CardID = fb.CartId;
            //    }

            //}
            //else
            //{

            //    ListViewItem itm = listView1.SelectedItems[0];
            //    if (listView1.SelectedItems.Count != 0)
            //    {
            //        var result = _cartServices.GetByCardCode(itm.SubItems[2].Text);
            //        if (result!=null)
            //        {
            //            CardID = result.Id;
            //        }
            //        else
            //        {
            //            AddorUpdateBtn.Text = "GÜNCELLE";
            //        }
            //        txtKasakod.Text = itm.SubItems[0].Text;
            //        txtKasatip.Text = itm.SubItems[1].Text;                    
            //        BoxID = itm.SubItems[3].Text;
            //        txtKartid.Text = itm.SubItems[2].Text;
            //    }

            //}
            //
        }

        private void KasaKayitController_Load(object sender, EventArgs e)
        {
            AddorUpdateBtn.Text = "KAYDET";
            list();
            listwidth();
        }

        //private void listView1_Click(object sender, EventArgs e)
        //{
        //    listget();
        //}

        private void Delete_Click(object sender, EventArgs e)
        {
            
            //Veri kaybı için bilgilendirme
            if (MessageBox.Show(WarningEnums.DataLoss, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool chk = _fboxService.Delete(BoxID);
                if (chk)
                {
                    MessageBox.Show(WarningEnums.DeleteSuccess, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
                
            list();
            BoxCount--;
            lbDocumentCount.Text = InputEnums.ToplamKayıt + BoxCount;
        }

        private async void btnCardRead_Click(object sender, EventArgs e)
        {
            CardID = "";
            BoxID = "";
            await _readerServices.WriteTagIdToTextboxAsync(txtKartid);
        }

        private void rnBoxType_CheckedChanged(object sender, EventArgs e)
        {
            tbSearch.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tbSearch.Focus();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            List<FishBox> FilteredFishBox;
            var Filter = FilterDefinition<FishBox>.Empty;

            if (rbBoxType.Checked)
            {
                Filter = Builders<FishBox>.Filter.Regex(x => x.FishBoxType, new MongoDB.Bson.BsonRegularExpression(search, "i"));
            }
            if (rbCardCode.Checked)
            {
                Filter = Builders<FishBox>.Filter.Regex(x => x.FishBoxCode, new MongoDB.Bson.BsonRegularExpression(search, "i"));
            }

            FilteredFishBox = _fboxService.GetFilteredFishBox(Filter);
            if(FilteredFishBox != null)
            {
                PageFilteredFishBoxToTable(FilteredFishBox);
            }

        }

        private void rbCardCode_CheckedChanged(object sender, EventArgs e)
        {
            tbSearch.Focus();
        }

        private void rbBoxType_CheckedChanged(object sender, EventArgs e)
        {
            tbSearch.Focus();
        }

        private void txtKartid_TextChanged(object sender, EventArgs e)
        {
            ////button2.Text = "Kaydet";
            //string cardcodetxt = txtKartid.Text.Trim();
            //if (!string.IsNullOrEmpty(cardcodetxt))
            //{
            //    var readCard = _cartServices.GetByCardCode(cardcodetxt);
            //    if (readCard!=null)
            //    {
            //        try
            //        {
            //            var readBox = _fboxService.GetByCardID(readCard.Id);
            //            var fb = _fboxService.Get(BoxID);
            //            if (readBox != null)
            //            {
            //                if (readCard.CartType == InputEnums.Kasa)
            //                {
            //                    if (string.IsNullOrEmpty(readBox.CartId))
            //                    {
            //                        button2.Text = "GÜNCELLE";
            //                    }
            //                    if (readBox.CartId != readCard.Id)
            //                    {
            //                        button2.Text = "Kaydet";
            //                    }
            //                    if (readBox.CartId == readCard.Id)
            //                    {
            //                        button2.Text = "GÜNCELLE";
            //                        listget(readCard);
            //                    }

            //                }
            //            }
            //            else if (string.IsNullOrEmpty(fb.CartId))
            //            {
            //                if (readCard.CartType == InputEnums.Kasa)
            //                {
            //                    if (string.IsNullOrEmpty(fb.CartId))
            //                    {
            //                        button2.Text = "GÜNCELLE";
            //                        listget(readCard);
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                button2.Text = "Kaydet";
            //            }

            //        }
            //        catch (Exception)
            //        {

            //            throw;
            //        }

            //    }

            //}
            #region Açıklama
            //Kart silinirse CardId ve Cardcode "" olacaktır. Bu durumu kontrol ediyoruz
            #endregion

            string cardcodetxt = txtKartid.Text.Trim();

            if (!string.IsNullOrEmpty(cardcodetxt))
            {
                var readCard = _cartServices.GetByCardCode(cardcodetxt);
                if (readCard != null)
                {
                    CardID = readCard.Id;
                    listget(readCard);//Buradaki methodda textboxa bir şey yazdığımız için textboxchanged eventini tetikliyoruz.Sonrasında kod blokları bir kere daha çalışıyor

                }
                else
                {

                }
            }
            else
            {
                if (!string.IsNullOrEmpty(BoxID))//Kayıt seçilmişse, cardid ve cardcode "" ise  çalışır.
                {
                    AddorUpdateBtn.Text = "GÜNCELLE";
                }
                else
                {
                    AddorUpdateBtn.Text = "KAYDET";
                }

            }
            if (!string.IsNullOrEmpty(BoxID))//Kayıt seçilmişse çalışır
            {
                AddorUpdateBtn.Text = "GÜNCELLE";
            }



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
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.25);
                            break;
                        case 2:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.5);
                            break;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void KasaKayitController_SizeChanged(object sender, EventArgs e)
        {
            listwidth();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                currentPage--;
                lbPagination.Text = currentPage + "/" + lastPage;
                list();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage != lastPage)
            {
                currentPage++;
                lbPagination.Text = currentPage + "/" + lastPage;
                list();
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
        private void BtnTextChanger(bool RecordType)
        {
            NewRecord = RecordType;
            if (RecordType)
            {
                AddorUpdateBtn.Text = "KAYDET";
                
            }
            else
            {
                AddorUpdateBtn.Text = "GÜNCELLE";
            }
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                BtnTextChanger(false);

                ListViewItem itm = listView1.SelectedItems[0];
                CardID = itm.SubItems[3].Text;
                txtKartid.Text = itm.SubItems[0].Text;
                txtKasakod.Text = itm.SubItems[1].Text;
                txtKasatip.Text = itm.SubItems[2].Text;


            }

        }
    }
}
