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
    public partial class KasaKayitController : UserControl
    {
        private readonly Services.IFishBoxServices _fboxService;
        public KasaKayitController()
        {
            InitializeComponent();
            _fboxService = new Services.FishBoxServices();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKartid.Text)) 
            {

                MessageBox.Show("LÜtfen Kart UUID'nizi gösteriniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txtKartid.Focus();
            
            }
            if (string.IsNullOrEmpty(txtKasakod.Text))
            {

                MessageBox.Show("LÜtfen Kart kodunuzu giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKartid.Focus();

            }
            if (string.IsNullOrEmpty(txtKasatip.Text))
            {

                MessageBox.Show("LÜtfen Kart tipinizi giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtKartid.Focus();

            }
            else
            {
                _fboxService.Create(new Entities.FishBox
                {
                    FishboxCartUUID = txtKartid.Text.Trim(),
                    FishBoxCode = txtKasakod.Text.Trim(),
                    FishBoxType = txtKasatip.Text.Trim(),
                    CreateDate=DateTime.Now



                });
            }
        }
    }
}
