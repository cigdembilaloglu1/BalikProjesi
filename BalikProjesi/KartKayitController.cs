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

namespace BalikProjesi
{
    public partial class KartKayitController : UserControl
    {
        private readonly ICartsServices1 _cartService;

        public KartKayitController()
        {
            InitializeComponent();
            _cartService = new CartsServices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(KartNameTxt.Text))
            {
                MessageBox.Show("Lütfen Kart Adını Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                KartNameTxt.Focus();
            }
            if (string.IsNullOrEmpty(KartKoduTb.Text))
            {
                MessageBox.Show("Lütfen Kart Kodunu Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                KartKoduTb.Focus();
            }
            else
            {
                _cartService.Create(new Entities.Carts
                {
                    CartCode = KartKoduTb.Text.Trim(),
                    CartName = KartNameTxt.Text.Trim(),
                    CartId = KartUUDTb.Text.Trim(),
                    CartType = KartTipiTb.Text.Trim(),
                    CreateDate = DateTime.Now
                });
            }
           
        }
    }
}
