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
        private readonly ReaderServices _readerServices;
        public PersonlKayitController()
        {
            InitializeComponent();
            _perService = new PersonelServices();
            _readerServices = new ReaderServices();
        }
        public void listviewDataGet()
        {
            if (listView1.SelectedItems.Count != 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];

                txtPersonelAd.Text = itm.SubItems[0].Text;
                txtPersonelSoyad.Text = itm.SubItems[1].Text;
                txtPersonelKod.Text = itm.SubItems[2].Text;
                txtKartID.Text = itm.SubItems[5].Text;
                
                for (int i = 0; i < cbPersonelGrup.Items.Count; i++)
                {
                    
                    if (cbPersonelGrup.Items[i].ToString() == itm.SubItems[3].Text.ToUpper()&&itm.SubItems[3] != null)
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

                label9.Text = itm.SubItems[6].Text;
                label10.Text = cbPersonelTur.Text;//düzenlenecek

            }
            else { }



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
                var dt = _perService.GetControl();
                pageListToTable(dt, perTur);

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    var val = listView1.Items[i].SubItems[4].Text;
                    if (val == InputEnums.Fileto)
                    {
                        listView1.Items[i].Remove();
                        i--;
                    }
                }
            }
            else
            {
                var dt = _perService.GetFillet();
                pageListToTable(dt, perTur);

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    var val = listView1.Items[i].SubItems[4].Text;
                    if (val == InputEnums.Kontrol)
                    {
                        listView1.Items[i].Remove();
                        i--;
                    }
                }
            }

            


            txtKartID.Clear();
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (txtKartID.Text == "")
            {
                MessageBox.Show("LÜtfen bir kart okutunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            if (txtKartID.Text == InputEnums.CardIsDefined)
            {
                MessageBox.Show("LÜtfen daha önce tanımlanmamış bir kart okutunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            if (string.IsNullOrEmpty(txtPersonelAd.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Adınızı Giriniz ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            if (string.IsNullOrEmpty(txtPersonelSoyad.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Soyadınızı Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            if (string.IsNullOrEmpty(txtPersonelKod.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Personel Kodunuzu Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            if (string.IsNullOrEmpty(cbPersonelGrup.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Personel Grubunuzu Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            if (string.IsNullOrEmpty(cbPersonelTur.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Personel Türünü Seçiniz ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                check = false;
            }
            

            if(check)
            {
                bool result;
                result =_perService.Create(new Personel
                {
                    PersonelName=txtPersonelAd.Text.Trim(),
                    PersonelSurname=txtPersonelSoyad.Text.Trim(),
                    PersonelGroup=cbPersonelGrup.Text.Trim(),
                    PersonelCode=txtPersonelKod.Text.Trim(),
                    CreateDate=DateTime.Now,
                    CartCode=txtKartID.Text.Trim()
                } ,cbPersonelTur.Text.Trim());
                if (result)
                {
                    MessageBox.Show("Personel kaydı başarılı.");
                }
                else
                {
                    MessageBox.Show("Personel kaydı başarısız. Girilen personel daha önceden kayıt edilmiştir.");
                }
                list(cbPersonelTur.Text);
            }


        }

        private void PersonlKayitController_Load(object sender, EventArgs e)
        {
            list(InputEnums.Kontrol);
            cbPersonelGrup.Items.Add(InputEnums.A);
            cbPersonelGrup.Items.Add(InputEnums.B);
            cbPersonelGrup.Items.Add(InputEnums.C);
            cbPersonelGrup.SelectedIndex = 0;
            cbPersonelTur.Items.Add(InputEnums.Fileto);
            cbPersonelTur.Items.Add(InputEnums.Kontrol);
            cbListGroup.Items.Add(InputEnums.Fileto);
            cbListGroup.Items.Add(InputEnums.Kontrol);
            cbListGroup.SelectedIndex = 1;
            cbPersonelTur.SelectedIndex = 1;
            label9.Visible = false;
            label10.Visible = false;
            

        }

        private void cbListGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            list(cbListGroup.Text);

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string persID = label9.Text;            
            string PersonelAd = txtPersonelAd.Text;
            string PersonelSoyad = txtPersonelSoyad.Text;
            string PersonelKod = txtPersonelKod.Text;
            string PersonelGrup = cbPersonelGrup.Text;
            string PersonelTur = cbPersonelTur.Text;
            string KartID = txtKartID.Text;

            Personel prs = new Personel();
            prs.Id = persID;
            prs.PersonelName = PersonelAd;
            prs.PersonelSurname = PersonelSoyad;
            prs.PersonelCode = PersonelKod;
            prs.PersonelGroup = PersonelGrup;
            prs.CartCode = KartID;

            bool chk=_perService.Update(prs, PersonelTur);
            if (chk==true)
            {
                MessageBox.Show("Güncelleme başarılı.");
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız. Girilen kayıt daha önce girilmiştir.");
            }
            list(cbPersonelTur.Text);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void gÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string persID = label9.Text;
            string PersonelAd = txtPersonelAd.Text;
            string PersonelSoyad = txtPersonelSoyad.Text;
            string PersonelKod = txtPersonelKod.Text;
            string PersonelGrup = cbPersonelGrup.Text;
            string PersonelTur = cbPersonelTur.Text;
            Personel prs = new Personel();
            string KartID = txtKartID.Text;
            prs.Id = persID;
            prs.PersonelName = PersonelAd;
            prs.PersonelSurname = PersonelSoyad;
            prs.PersonelCode = PersonelKod;
            prs.PersonelGroup = PersonelGrup;
            prs.CartId = KartID;
            bool chk = _perService.Update(prs, PersonelTur);
            if (chk == true)
            {
                MessageBox.Show("Güncelleme başarılı.");
            }
        }

        private async void btnReader_Click(object sender, EventArgs e)
        {
            _readerServices.openPort();

            bool tagIsDefined = await _readerServices.checkTagIsDefined();

            if (!tagIsDefined)
            {
                await _readerServices.setTagIdToTextboxAsync(txtKartID);
            }
            else
            {
                txtKartID.Text = InputEnums.CardIsDefined;
            }

            //_readerServices.closePort();
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool chk=_perService.Delete(label9.Text, label10.Text);
            MessageBox.Show(chk.ToString());
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            listviewDataGet();
        }

        private void PersonlKayitController_SizeChanged(object sender, EventArgs e)
        {
            int width = this.Width;
            try
            {
                for (int i = 0; i < listView1.Columns.Count - 1; i++)
                {
                    listView1.Columns[i].Width = width / 6;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
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
            else 
            {
                filteredPersonelList = _perService.GetFilteredController(Filter);
            }

            pageListToTable(filteredPersonelList);
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
    }
}
