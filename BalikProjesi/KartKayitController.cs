﻿using BalikProjesi.Entities;
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
using BalikProjesi.Enums;

namespace BalikProjesi
{
    public partial class KartKayitController : UserControl
    {
        private readonly ICartsServices1 _cartService;
        private string CardID = "";
        private readonly ReaderServices _readerServices;
        private readonly IPersonelServices _personelService;
        private readonly IFishBoxServices _fishboxService;


        public KartKayitController()
        {
            InitializeComponent();
            _cartService = new CartsServices();
            _readerServices = new ReaderServices();
            _personelService = new PersonelServices();
            _fishboxService = new FishBoxServices();
            CardID = "";
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
            CardID = "";
        }
        public void listget(Carts card=null)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];

                KartNameTxt.Text = itm.SubItems[0].Text;
                KartKoduTb.Text = itm.SubItems[1].Text;
                KartTipiTb.Text = itm.SubItems[2].Text;
                CardID = itm.SubItems[3].Text;


            }
            else
            {
                KartNameTxt.Text = card.CartName;
                KartKoduTb.Text = card.CartCode;
                KartTipiTb.Text = card.CartType;
                CardID = card.Id;
                MessageBox.Show("hshhss");
            }

        }
        public void dataupdate()
        {

            string CartName = KartNameTxt.Text.Trim();
            string CartCode = KartKoduTb.Text.Trim();
            string CartType = KartTipiTb.Text.Trim();
            Entities.Carts ct = new Carts();
            var fb=_fishboxService.GetByCardID(CardID);
            var fileto = _personelService.GetFilletPersonnelByCardId(CardID);
            var kontrol = _personelService.GetControlPersonnelByCardId(CardID);
            void temp()
            {
                ct.CartName = CartName;
                ct.CartCode = CartCode;
                ct.CartType = CartType;
                ct.Id = CardID;
                ct.UpdateDate = DateTime.Now;
            }
            //MessageBox.Show(CardID);
            if (!string.IsNullOrEmpty(CardID))
            {
                if (fb!=null)
                {
                    fb.CartCode = "";
                    temp();
                }
                if (fileto!=null)
                {
                    fileto.CartCode = "";
                    temp();
                }
                if (kontrol != null)
                {
                    fileto.CartCode = "";
                    temp();
                }


                
                
                bool chk = _cartService.Update(ct, CartName);
                if (chk == true)
                {
                    MessageBox.Show("Güncelleme başarılı.");
                }
                else
                {
                    MessageBox.Show("Güncelleme başarısız.");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen listeden güncellemek istediğiniz kaydı seçiniz veya kartınızı okutunuz");
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
                var result =_cartService.Create(new Entities.Carts
                {
                    CartCode = KartKoduTb.Text.Trim(),
                    CartName = KartNameTxt.Text.Trim(),                    
                    CartType = KartTipiTb.Text.Trim(),
                    CreateDate = DateTime.Now
                });
                if (result)
                {
                    MessageBox.Show("Kayıt Başarılıyla girilmiştir.");
                }
                else
                {
                    MessageBox.Show("Kayıt Girilememiştir.");
                }
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

        private void DeleteMenuStrip_Click(object sender, EventArgs e)
        {
            var result=_cartService.Delete(CardID);
            MessageBox.Show(result.ToString());
            liste();
        }

        private async void bntCardReader_Click(object sender, EventArgs e)
        {
            string cardcodetxt = KartKoduTb.Text.Trim();
            var readCard = _cartService.GetByCardCode(cardcodetxt);
            if (readCard!=null)
            {
                listget(readCard);
            }
            //_readerServices.openPort();

            //bool tagIsDefined = await _readerServices.checkTagIsDefined();

            //if (!tagIsDefined)
            //{
            //    await _readerServices.setTagIdToTextboxAsync(KartKoduTb);
            //}
            //else
            //{
            //    KartKoduTb.Text = InputEnums.CardIsDefined;
            //}

        }

        private void KartKayitController_SizeChanged(object sender, EventArgs e)
        {
            
            int width = this.Width;
            
            try
            {
                for (int i = 0; i < listView1.Columns.Count-1; i++)
                {
                    
                    switch (i)
                    {
                        case 0:
                            listView1.Columns[i].Width = Convert.ToInt32(width*0.25);
                         break;
                        case 1:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.5);
                            break;
                        case 2:
                            listView1.Columns[i].Width = Convert.ToInt32(width * 0.25);
                            break;
                        
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
