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
        public void liste()
        {
            string CartAd, CartCode, CartType, CartUUID;
            if (listView1.Items.Count != 0)
            {
                listView1.Items.Clear();
            }
            var dt = _cartService.Get();
            foreach (var item in dt)
            {
                CartAd = item.CartName;
                CartCode = item.CartCode;
                CartType = item.CartType;
               CartUUID = item.CartId;
               
                string[] data = { CartAd, CartCode, CartType, CartUUID };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
            KartNameTxt.Clear();
            KartKoduTb.Clear();
            KartTipiTb.Clear();
            KartUUDTb.Clear();



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
                liste();
            }
           
        }
    }
}
