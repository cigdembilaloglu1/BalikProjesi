using BalikProjesi.Enums;
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
using BalikProjesi.Services;
using MongoDB.Driver;

namespace BalikProjesi
{
    public partial class PersonlKayitController : UserControl
    {
        private readonly IPersonelServices _perService;
        private readonly ICartsServices1 _cartsServices;
        private readonly ReaderServices _readerServices;
        private string persID;
        private string CardID;
        private string PersTuru;
        private long FilletPersonalCount;
        private long ControllerPersonalCount;
        private int currentPage;
        private long lastPage;
        public PersonlKayitController()
        {
            InitializeComponent();
            _perService = new PersonelServices();
            _readerServices = new ReaderServices();
            _cartsServices = new CartsServices();
            persID = "";
            CardID = "";
            PersTuru = "";
            FilletPersonalCount = _perService.GetFilletDocumentCount();
            ControllerPersonalCount = _perService.GetControllerDocumentCount();
            currentPage = 1;
            lastPage = DivideRoundingUp(FilletPersonalCount + ControllerPersonalCount, 15);
            lbPagination.Text = currentPage + "/" + lastPage;

            int maxWidthSize = Screen.PrimaryScreen.Bounds.Width;
            listView1.MaximumSize = new Size(maxWidthSize - 10, 282);
            listView1.MaximumSize = new Size(0, 282);

            lbDocumentCount.Text = InputEnums.ToplamKayıt + FilletPersonalCount + ControllerPersonalCount;

        }
        public void listviewDataGet(Carts card = null)
        {

            if (card != null)
            {
                var prsFillet = _perService.GetFilletPersonnelByCardId(card.Id);
                var prsControl = _perService.GetControlPersonnelByCardId(card.Id);

                if (card.CartType == InputEnums.Fileto && prsFillet != null)
                {

                    if (prsFillet != null)
                    {
                        txtPersonelAd.Text = prsFillet.PersonelName;
                        txtPersonelSoyad.Text = prsFillet.PersonelSurname;
                        txtPersonelKod.Text = prsFillet.PersonelCode;
                        txtKartID.Text = prsFillet.CartCode;
                        for (int i = 0; i < cbPersonelGrup.Items.Count; i++)
                        {

                            if (cbPersonelGrup.Items[i].ToString() == prsFillet.PersonelGroup.ToUpper() && prsFillet.PersonelGroup != null)
                            {
                                cbPersonelGrup.SelectedItem = prsFillet.PersonelGroup.ToUpper();

                            }

                        }
                        for (int i = 0; i < cbPersonelTur.Items.Count; i++)
                        {
                            cbPersonelTur.SelectedItem = InputEnums.Fileto;
                        }
                        persID = prsFillet.Id;
                        PersTuru = cbPersonelTur.Text;
                        CardID = prsFillet.CartId;

                    }

                }
                else if (card.CartType == InputEnums.Kontrol && prsControl != null)
                {
                    if (prsControl != null)
                    {
                        txtPersonelAd.Text = prsControl.PersonelName;
                        txtPersonelSoyad.Text = prsControl.PersonelSurname;
                        txtPersonelKod.Text = prsControl.PersonelCode;
                        txtKartID.Text = prsControl.CartCode;
                        for (int i = 0; i < cbPersonelGrup.Items.Count; i++)
                        {

                            if (cbPersonelGrup.Items[i].ToString() == prsControl.PersonelGroup.ToUpper() && prsControl.PersonelGroup != null)
                            {
                                cbPersonelGrup.SelectedItem = prsControl.PersonelGroup.ToUpper();

                            }

                        }
                        for (int i = 0; i < cbPersonelTur.Items.Count; i++)
                        {
                            cbPersonelTur.SelectedItem = InputEnums.Kontrol;
                        }
                        persID = prsControl.Id;
                        PersTuru = cbPersonelTur.Text;
                        CardID = prsControl.CartId;


                    }

                }
                else
                {
                    RefreshInputs();
                }
                //button1.Text = "GÜNCELLE";
            }
            else
            {
                ListViewItem itm = listView1.SelectedItems[0];
                if (listView1.SelectedItems.Count != 0)
                {

                    txtPersonelAd.Text = itm.SubItems[0].Text;
                    txtPersonelSoyad.Text = itm.SubItems[1].Text;
                    txtPersonelKod.Text = itm.SubItems[2].Text;
                    txtKartID.Text = itm.SubItems[5].Text;

                    for (int i = 0; i < cbPersonelGrup.Items.Count; i++)
                    {

                        if (cbPersonelGrup.Items[i].ToString() == itm.SubItems[3].Text.ToUpper() && itm.SubItems[3] != null)
                        {
                            cbPersonelGrup.SelectedItem = itm.SubItems[3].Text.ToUpper();

                        }

                    }
                    for (int i = 0; i < cbPersonelTur.Items.Count; i++)
                    {
                        if (cbPersonelTur.Items[i].ToString() == itm.SubItems[4].Text && itm.SubItems[4] != null)
                        {
                            cbPersonelTur.SelectedItem = itm.SubItems[4].Text;

                        }

                    }
                    var result = _cartsServices.GetByCardCode(itm.SubItems[5].Text);
                    if (result != null)
                    {
                        CardID = result.Id;
                        
                    }
                    else
                    {
                        button1.Text = "GÜNCELLE";
                    }
                    persID = itm.SubItems[6].Text;
                    PersTuru = cbPersonelTur.Text;
                }
               
            }
        }

        public void pageListToTable(List<Personel> tableList, string perTur = null)
        {
            if (listView1.Items.Count != 0)
            {
                listView1.Items.Clear();
            }

            string PerAd, PerSoyad, PerKod, PerGrup, PerTur, PerCID, PerId;

            foreach (var item in tableList)
            {
                PerAd = item.PersonelName;
                PerSoyad = item.PersonelSurname;
                PerKod = item.PersonelCode;
                PerGrup = item.PersonelGroup;
                if(perTur == null || perTur == InputEnums.Tumu)
                    PerTur = item.CartType;
                else
                    PerTur = perTur;
                PerCID = item.CartCode;
                PerId = item.Id;
                string[] data = { PerAd, PerSoyad, PerKod, PerGrup, PerTur, PerCID, PerId };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
        }

        public void list(string perTur = null)
        {
            if (perTur == InputEnums.Kontrol)
            {
                var dt = _perService.GetControl(currentPage);

                listView1.Items.Clear();
                pageListToTable(dt, perTur);
            }
            else if (perTur == InputEnums.Fileto)
            {
                var dt = _perService.GetFillet(currentPage);

                listView1.Items.Clear();
                pageListToTable(dt, perTur);
            }
            else//tümü
            {
                var dt = _perService.GetAll(currentPage);

                listView1.Items.Clear();
                pageListToTable(dt);
            }

            RefreshInputs();
            txtKartID.Clear();
            txtPersonelKod.Clear();
        }

        public void SelectedClear()
        {

            foreach (var item in listView1.SelectedItems)
            {
                listView1.SelectedItems.Clear();

            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SelectedClear();

        }
        void Create()
        {
            bool check = true;
            string cardCode = txtKartID.Text;
            int cardType;
            if (cbPersonelTur.Text == InputEnums.Fileto)
                cardType = 0;
            else
                cardType = 1;

            bool personalCollecitonsResult = _perService.PCardCodeExist(cardCode);
            int cardCollectionResult = _cartsServices.CheckCardTypeResult(cardCode);


            if (txtKartID.Text == "" || txtPersonelAd.Text == "" || txtPersonelSoyad.Text == "" || txtPersonelKod.Text == "")
            {
                MessageBox.Show(WarningEnums.PleaseFillAllFields, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            else if (cardCollectionResult == -1)//Kart Carts Collection'da kayıtlı değilse
            {
                MessageBox.Show(WarningEnums.DefineToCardCollection, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            else if (cardCollectionResult == 2)//CardType Kasa İse
            {
                MessageBox.Show(WarningEnums.CardTypeIsNotPersonal, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            else if (cardCollectionResult != cardType)//CardType cbPersonelTurdaki değere eşit değilse
            {
                MessageBox.Show(WarningEnums.CardTypeIsNotValid, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            else if (personalCollecitonsResult)//Kart başka bir personele kayıtlımı
            {
                MessageBox.Show(WarningEnums.CardIsDefined, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }

            if (check)
            {
                var result = _perService.Create(new Personel
                {
                    PersonelName = txtPersonelAd.Text.Trim(),
                    PersonelSurname = txtPersonelSoyad.Text.Trim(),
                    PersonelGroup = cbPersonelGrup.Text.Trim(),
                    PersonelCode = txtPersonelKod.Text.Trim(),
                    CreateDate = DateTime.Now,
                    CartCode = txtKartID.Text.Trim(),
                    CartId = CardID,
                    CartType = cbPersonelTur.Text
                }, cbPersonelTur.Text.Trim());
                if (result)
                {
                    MessageBox.Show(WarningEnums.CreateSuccess, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    switch (cbPersonelTur.Text)
                    {
                        case InputEnums.Fileto:
                            FilletPersonalCount--;
                            lbDocumentCount.Text = InputEnums.ToplamKayıt + FilletPersonalCount;
                            break;
                        case InputEnums.Kontrol:
                            ControllerPersonalCount--;
                            lbDocumentCount.Text = InputEnums.ToplamKayıt + ControllerPersonalCount;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show(WarningEnums.CreateFailed, WarningEnums.Uyarı, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                list(cbPersonelTur.Text);
            }
        }
        void update()
        {

            string PersonelAd = txtPersonelAd.Text.Trim();
            string PersonelSoyad = txtPersonelSoyad.Text.Trim();
            string PersonelKod = txtPersonelKod.Text.Trim();
            string PersonelGrup = cbPersonelGrup.Text.Trim();
            string PersonelTur = cbPersonelTur.Text.Trim();
            string KartID = txtKartID.Text;
            var readCard = _cartsServices.GetByCardCode(KartID);
            if (readCard != null)
            {
                CardID = readCard.Id;
            }
            else
            {
                if (KartID == "")
                {
                    MessageBox.Show(WarningEnums.InvalidSelection);
                }
                else
                {
                    MessageBox.Show(WarningEnums.DefineToCardCollection);
                }

            }
            if (!string.IsNullOrEmpty(persID) && readCard != null)
            {
                if (PersonelTur == readCard.CartType)
                {
                    Personel prs = new Personel();
                    prs.Id = persID;
                    prs.PersonelName = PersonelAd;
                    prs.PersonelSurname = PersonelSoyad;
                    prs.PersonelCode = PersonelKod;
                    prs.PersonelGroup = PersonelGrup;
                    prs.CartCode = KartID;
                    prs.CartId = CardID;
                    bool chk = _perService.Update(prs, PersonelTur);
                    if (chk == true)
                    {
                        MessageBox.Show(WarningEnums.UpdateSuccess);
                    }
                    else
                    {
                        MessageBox.Show(WarningEnums.UpdateFailed);
                    }
                }
                else
                {
                    MessageBox.Show("Okunan kart " + readCard.CartType + " kartıdır. Kaydı yapabilmeniz için " + PersonelTur + " tipinde bir kart gerekmektedir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            list(cbPersonelTur.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="KAYDET")
            {
                Create();
                list();
            }
            else if (button1.Text=="GÜNCELLE")
            {
                if (MessageBox.Show(WarningEnums.AskUpdate, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    update();
                    list();
                }
                else
                {
                    list();
                }

            }
        }

        private void PersonlKayitController_Load(object sender, EventArgs e)
        {
            list();
            cbPersonelGrup.Items.Add(InputEnums.A);
            cbPersonelGrup.Items.Add(InputEnums.B);
            cbPersonelGrup.Items.Add(InputEnums.C);
            cbPersonelGrup.SelectedIndex = 0;
            cbPersonelTur.Items.Add(InputEnums.Fileto);
            cbPersonelTur.Items.Add(InputEnums.Kontrol);
            cbListGroup.Items.Add(InputEnums.Tumu);
            cbListGroup.Items.Add(InputEnums.Fileto);
            cbListGroup.Items.Add(InputEnums.Kontrol);
            cbListGroup.SelectedIndex = 0;
            cbPersonelTur.SelectedIndex = 1;

        }

        private void cbListGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            list(cbListGroup.Text);

            if (cbListGroup.Text == InputEnums.Fileto)
            {
                lastPage = DivideRoundingUp(FilletPersonalCount, 15);
                lbDocumentCount.Text = InputEnums.ToplamKayıt + FilletPersonalCount;
            }
            else if (cbListGroup.Text == InputEnums.Kontrol)
            {
                lastPage = DivideRoundingUp(ControllerPersonalCount, 15);
                lbDocumentCount.Text = InputEnums.ToplamKayıt + ControllerPersonalCount;
            }
            else
            {
                lastPage = DivideRoundingUp(FilletPersonalCount + ControllerPersonalCount, 15);
                lbDocumentCount.Text = InputEnums.ToplamKayıt + (FilletPersonalCount + ControllerPersonalCount);
            }
                
        }



        private void button2_Click(object sender, EventArgs e)
        {

            //string PersonelAd = txtPersonelAd.Text.Trim();
            //string PersonelSoyad = txtPersonelSoyad.Text.Trim();
            //string PersonelKod = txtPersonelKod.Text.Trim();
            //string PersonelGrup = cbPersonelGrup.Text.Trim();
            //string PersonelTur = cbPersonelTur.Text.Trim();
            //string KartID = txtKartID.Text;
            //var readCard = _cartsServices.GetByCardCode(KartID);//
            //if (readCard != null)
            //{
            //    CardID = readCard.Id;
            //}
            //else
            //{
            //    if (KartID == "")
            //    {
            //        MessageBox.Show(WarningEnums.InvalidSelection);
            //    }
            //    else
            //    {
            //        MessageBox.Show(WarningEnums.DefineToCardCollection);
            //    }

            //}
            //if (!string.IsNullOrEmpty(persID) && readCard != null)
            //{
            //    if (PersonelTur == readCard.CartType)
            //    {
            //        Personel prs = new Personel();
            //        prs.Id = persID;
            //        prs.PersonelName = PersonelAd;
            //        prs.PersonelSurname = PersonelSoyad;
            //        prs.PersonelCode = PersonelKod;
            //        prs.PersonelGroup = PersonelGrup;
            //        prs.CartCode = KartID;
            //        prs.CartId = CardID;
            //        bool chk = _perService.Update(prs, PersonelTur);
            //        if (chk == true)
            //        {
            //            MessageBox.Show(WarningEnums.UpdateSuccess);
            //        }
            //        else
            //        {
            //            MessageBox.Show(WarningEnums.UpdateFailed);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Okunan kart " + readCard.CartType + " kartıdır. Kaydı yapabilmeniz için " + PersonelTur + " tipinde bir kart gerekmektedir.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    }
            //}

            list();
        }

      

        private async void btnReader_Click(object sender, EventArgs e)
        {
            await _readerServices.WriteTagIdToTextboxAsync(txtKartID);
        }

        #region gereksiz
        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //Veri kaybı için bilgilendirme
            if (MessageBox.Show(WarningEnums.DataLoss, WarningEnums.Uyarı, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool chk = _perService.Delete(persID, PersTuru);
                if (chk)
                {
                    MessageBox.Show(WarningEnums.DeleteSuccess, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


                    if (listView1.SelectedItems[0].SubItems[4].Text == InputEnums.Fileto)
                    {
                        FilletPersonalCount--;
                    }
                    else
                    {
                        ControllerPersonalCount--;
                    }

                    switch (cbListGroup.Text)
                    {
                        case InputEnums.Fileto:
                            lbDocumentCount.Text = InputEnums.ToplamKayıt + FilletPersonalCount;
                            break;
                        case InputEnums.Kontrol:
                            lbDocumentCount.Text = InputEnums.ToplamKayıt + ControllerPersonalCount;
                            break;
                        case InputEnums.Tumu:
                            lbDocumentCount.Text = InputEnums.ToplamKayıt + (ControllerPersonalCount + FilletPersonalCount);
                            break;
                    }

                }
                list();
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        #endregion



        private void listView1_Click(object sender, EventArgs e)
        {
            listviewDataGet();
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
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.15);
                            break;
                        case 1:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.15);
                            break;
                        case 2:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.15);
                            break;
                        case 3:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.1);
                            break;
                        case 4:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.15);
                            break;
                        case 5:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.3);
                            break;
                        

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PersonlKayitController_SizeChanged(object sender, EventArgs e)
        {
            //int width = this.Width;
            //try
            //{
            //    for (int i = 0; i < listView1.Columns.Count - 1; i++)
            //    {
            //        listView1.Columns[i].Width = width / 6;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            listwidth();

        }

        private void mtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = mtSearch.Text;
            var Filter = FilterDefinition<Personel>.Empty;

            if (rbName.Checked)
            {
                Filter = Builders<Personel>.Filter.Regex(x => x.PersonelName, new MongoDB.Bson.BsonRegularExpression(search, "i"));
            }
            if (rbSurname.Checked)
            {
                Filter = Builders<Personel>.Filter.Regex(x => x.PersonelSurname, new MongoDB.Bson.BsonRegularExpression(search, "i"));
            }
            if (rbCode.Checked)
            {
                Filter = Builders<Personel>.Filter.Regex(x => x.PersonelCode, new MongoDB.Bson.BsonRegularExpression(search, "i"));
            }
            if (rbGroup.Checked)
            {
                Filter = Builders<Personel>.Filter.Regex(x => x.PersonelGroup, new MongoDB.Bson.BsonRegularExpression(search, "i"));
            }

            List<Personel> filteredPersonelList;
            if (cbListGroup.Text == InputEnums.Fileto)
            {
                filteredPersonelList = _perService.GetFilteredFillet(Filter);
            }
            else if(cbListGroup.Text == InputEnums.Kontrol)
            {
                filteredPersonelList = _perService.GetFilteredController(Filter);
            }
            else
            {
                filteredPersonelList = _perService.GetFilteredPersonal(Filter);
            }

            pageListToTable(filteredPersonelList, cbPersonelTur.Text);
        }

        private void rbCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCode.Checked)
            {
                mtSearch.Mask = "00000";
            }
            else
            {
                mtSearch.Mask = "";
            }

            mtSearch.Focus();
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            mtSearch.Focus();
        }

        private void rbSurname_CheckedChanged(object sender, EventArgs e)
        {
            mtSearch.Focus();
        }

        private void rbGroup_CheckedChanged(object sender, EventArgs e)
        {
            mtSearch.Focus();
        }

        private void txtKartID_TextChanged(object sender, EventArgs e)
        {
            string cardcodetxt = txtKartID.Text.Trim();

            if (!string.IsNullOrEmpty(cardcodetxt))
            {
                var readCard = _cartsServices.GetByCardCode(cardcodetxt);
                if (readCard != null)
                {
                    if (readCard.CartType == InputEnums.Fileto)
                        cbPersonelTur.SelectedItem = 0;
                    else if (readCard.CartType == InputEnums.Kontrol)
                        cbPersonelTur.SelectedItem = 1;

                    txtPersonelKod.Text = readCard.CartName;
                    CardID = readCard.Id;
                    listviewDataGet(readCard);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(persID))
                {
                    button1.Text = "GÜNCELLE";
                }
                else
                {
                    button1.Text = "KAYDET";
                }

            }
            if (!string.IsNullOrEmpty(persID))
            {
                button1.Text = "GÜNCELLE";
            }
            
        }

        private void RefreshInputs()
        {
            cbPersonelGrup.SelectedItem = 0;
            cbPersonelTur.SelectedItem = 0;
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();

            CardID = "";
            persID = "";
            button1.Text = "KAYDET";
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                currentPage--;
                lbPagination.Text = currentPage + "/" + lastPage;
                list(cbListGroup.Text);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage != lastPage)
            {
                currentPage++;
                lbPagination.Text = currentPage + "/" + lastPage;
                list(cbListGroup.Text);
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
