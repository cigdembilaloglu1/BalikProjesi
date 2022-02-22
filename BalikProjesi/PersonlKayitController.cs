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

namespace BalikProjesi
{
    public partial class PersonlKayitController : UserControl
    {
        private readonly Services.IPersonelServices _perService;
        public PersonlKayitController()
        {
            InitializeComponent();
            _perService = new Services.PersonelServices();
        }

        public void list(string group = null)
        {
            string PerAd, PerSoyad, PerKod, PerGrup, PerTur, PerCID,PerId;
            if (listView1.Items.Count!=0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items.Clear();
                }
            }

            if (group == InputEnums.Kontrol)
            {

                var dt = _perService.GetControl();
                foreach (var item in dt)
                {
                    PerAd = item.PersonelName;
                    PerSoyad = item.PersonelSurname;
                    PerKod = item.PersonelCode;
                    PerGrup = item.PersonelGroup;
                    PerTur = group;
                    PerCID = item.CartId;
                    PerId = item.Id;
                    string[] data = { PerAd, PerSoyad, PerKod, PerGrup, PerTur, PerCID,PerId };
                    ListViewItem record = new ListViewItem(data);
                    listView1.Items.Add(record);
                }
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
                foreach (var item in dt)
                {
                    PerAd = item.PersonelName;
                    PerSoyad = item.PersonelSurname;
                    PerKod = item.PersonelCode;
                    PerGrup = item.PersonelGroup;
                    PerTur = group;
                    PerCID = item.CartId;
                    PerId = item.Id;
                    string[] data = { PerAd, PerSoyad, PerKod, PerGrup, PerTur, PerCID, PerId };
                    ListViewItem record = new ListViewItem(data);
                    listView1.Items.Add(record);
                }
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
            cbPersonelGrup.Text = "";
            cbPersonelTur.Text = "";


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
            if (string.IsNullOrEmpty(txtKartID.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Kart UUID'nizi gösteriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKartID.Focus();
            }
            if (string.IsNullOrEmpty(txtPersonelAd.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Adınızı Giriniz ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKartID.Focus();
            }
            if (string.IsNullOrEmpty(txtPersonelSoyad.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Soyadınızı Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKartID.Focus();
            }
            if (string.IsNullOrEmpty(txtPersonelKod.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Personel Kodunuzu Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKartID.Focus();
            }
            if (string.IsNullOrEmpty(cbPersonelGrup.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Personel Grubunuzu Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKartID.Focus();
            }
            if (string.IsNullOrEmpty(cbPersonelTur.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Personel Türünüzü Seçiniz ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKartID.Focus();
            }
            else
            {
                _perService.Create(new Entities.Personel
                {
                    PersonelName=txtPersonelAd.Text.Trim(),
                    PersonelSurname=txtPersonelSoyad.Text.Trim(),
                    PersonelGroup=cbPersonelGrup.Text.Trim(),
                    PersonelCode=txtPersonelKod.Text.Trim(),
                    CreateDate=DateTime.Now,
                    CartId=txtKartID.Text.Trim()
              } ,cbPersonelTur.Text.Trim());
                
                list();

            }


        }

        private void PersonlKayitController_Load(object sender, EventArgs e)
        {
            list(InputEnums.Kontrol);
            cbPersonelTur.Items.Add(InputEnums.Fileto);
            cbPersonelTur.Items.Add(InputEnums.Kontrol);
            cbListGroup.Items.Add(InputEnums.Fileto);
            cbListGroup.Items.Add(InputEnums.Kontrol);
            cbListGroup.SelectedIndex = 1;
            cbPersonelTur.SelectedIndex = 1;



        }

        private void cbListGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            list(cbListGroup.Text);

        }
    }
}
