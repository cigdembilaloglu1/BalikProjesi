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

namespace BalikProjesi
{
    public partial class KasaKayitController : UserControl
    {
        private readonly Services.IFishBoxServices _fboxService;
        private readonly Services.ReaderServices _readerServices;
        private string BoxID;
        public KasaKayitController()
        {
            InitializeComponent();
            _fboxService = new Services.FishBoxServices();
            BoxID = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (check)
            {
                var result = _fboxService.Create(new FishBox
                {
                    CreateDate = DateTime.Now,
                    FishBoxCode = txtKasakod.Text.Trim(),
                    FishBoxType = txtKasatip.Text.Trim(),
                    CartCode = txtKasakod.Text
                });
                switch (result)
                {
                    case true:
                        MessageBox.Show("Kasa kaydı başarılı.");
                        break;                        
                    case false:
                        MessageBox.Show("Kasa kaydı başarısız. Girilen kasa daha önceden kayıt edilmiştir.");
                        break;
                }
            }
            
        }
        void list()
        {
            listView1.Items.Clear();
            string boxcode, boxtype, boxcardid;
            var dt = _fboxService.Get();
            foreach (var item in dt)
            {
                boxcode = item.FishBoxCode;
                boxtype = item.FishBoxType;
                boxcardid = item.CartCode;                
                BoxID = item.Id;
                string[] data = { boxcode, boxtype, boxcardid,BoxID };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
            txtKartid.Clear();
            txtKasakod.Clear();
            txtKasatip.Clear();
            BoxID = "";
        }
        void listviewDataGet()
        {
            ListViewItem itm = listView1.SelectedItems[0];
            if (listView1.SelectedItems.Count != 0)
            {
                txtKasakod.Text = itm.SubItems[0].Text;
                txtKasatip.Text = itm.SubItems[1].Text;
                txtKartid.Text = itm.SubItems[2].Text;
                BoxID = itm.SubItems[3].Text;
            }
        }

        private void KasaKayitController_Load(object sender, EventArgs e)
        {
            list();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            listviewDataGet();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            bool chk = _fboxService.Delete(BoxID);
            MessageBox.Show(chk.ToString());
            list();
        }

        private async void btnCardRead_Click(object sender, EventArgs e)
        {
            _readerServices.openPort();

            bool tagIsDefined = await _readerServices.checkTagIsDefined();

            if (!tagIsDefined)
            {
                await _readerServices.setTagIdToTextboxAsync(txtKartid);
            }
            else
            {
                txtKartid.Text = InputEnums.CardIsDefined;
            }
        }
    }
}
