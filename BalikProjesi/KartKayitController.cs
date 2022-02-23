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
                CartUUID = item.Id;

                string[] data = { CartAd, CartCode, CartType, CartUUID };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
            KartNameTxt.Clear();
            KartKoduTb.Clear();
            KartTipiTb.Clear();
            KartUUDTb.Clear();



        }
        public void listget()
        {
            if (listView1.SelectedItems.Count != 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];

                KartNameTxt.Text = itm.SubItems[0].Text;
                KartKoduTb.Text = itm.SubItems[1].Text;
                KartTipiTb.Text = itm.SubItems[2].Text;
                KartUUDTb.Text = itm.SubItems[3].Text;


            }

        }
        public void dataupdate()
        {

            string CartName = KartNameTxt.Text;
            string CartCode = KartKoduTb.Text;
            string CartType = KartTipiTb.Text;
            string CartUUID = KartUUDTb.Text;

            Entities.Carts ct = new Carts();
            

            ct.CartName = CartName;
            ct.CartCode = CartCode;
            ct.CartType = CartType;
            ct.Id = CartUUID;
            ct.UpdateDate= DateTime.Now;
            bool chk = _cartService.Update(ct,CartName);
            if (chk == true)
            {
                MessageBox.Show("Güncelleme başarılı.");
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız. Girilen kayıt daha önce girilmiştir.");
            }
            liste();
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
            dataupdate();
            
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            listget();
        }

        private void KartKayitController_Load_1(object sender, EventArgs e)
        {
            liste();
        }
    }
}
