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
            _perService= new Services.PersonelServices();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKartID.Text.Trim()))
            {
                MessageBox.Show("LÜtfen Kart UUID'nizi gösteriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                },comboBox1.Text.Trim());
            }

        }

        private void PersonlKayitController_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(InputEnums.Fileto);
            comboBox1.Items.Add(InputEnums.Kontrol);
        }
    }
}
