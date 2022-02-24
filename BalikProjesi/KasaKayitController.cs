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
        private readonly Services.ICartsServices1 _cartServices;

        private string BoxID;
        private string CardID;
        public KasaKayitController()
        {
            InitializeComponent();
            _fboxService = new Services.FishBoxServices();
            _cartServices = new Services.CartsServices();
            BoxID = "";
            CardID = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void dataupdate()
        {

            string boxcode = txtKasakod.Text.Trim();
            string CartCode =txtKartid.Text.Trim();
            string boxtype = txtKasatip.Text.Trim();
            var readCard = _cartServices.GetByCardCode(CartCode);
            if (readCard != null)
            {
                CardID = readCard.Id;                
            }
            if (!string.IsNullOrEmpty(BoxID))
            {
                Entities.FishBox fb = new FishBox();


                fb.FishBoxCode = boxcode;
                fb.CartCode = CartCode;
                fb.FishBoxType = boxtype;
                fb.Id = BoxID;
                fb.UpdateDate = DateTime.Now;
                bool chk = _fboxService.Update(fb);
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
            list();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataupdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (check)
            {
                //var readCard = _cartServices.GetByCardCode(CartCode);
                if (readCard != null)
                {
                    CardID = readCard.Id;
                }
                var result = _fboxService.Create(new FishBox
                {
                    CreateDate = DateTime.Now,
                    FishBoxCode = txtKasakod.Text.Trim(),
                    FishBoxType = txtKasatip.Text.Trim(),
                    CartCode = txtKartid.Text.Trim(),
                    CartId = CardID
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
            list();
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
                string[] data = { boxcode, boxtype, boxcardid, BoxID };
                ListViewItem record = new ListViewItem(data);
                listView1.Items.Add(record);
            }
            txtKartid.Clear();
            txtKasakod.Clear();
            txtKasatip.Clear();
            BoxID = "";
            CardID = "";
        }
        void listget(Carts card=null)
        {
            if (card!=null)
            {
                var fb = _fboxService.GetByCardID(card.Id);
                if (fb!=null)
                {
                    txtKasakod.Text = fb.FishBoxCode;
                    txtKasatip.Text = fb.FishBoxType;
                    txtKartid.Text = fb.CartCode;
                    BoxID = fb.Id;
                    CardID = fb.CartId;
                }
                
            }
            else
            {
                ListViewItem itm = listView1.SelectedItems[0];
                if (listView1.SelectedItems.Count != 0)
                {
                    txtKasakod.Text = itm.SubItems[0].Text;
                    txtKasatip.Text = itm.SubItems[1].Text;
                    txtKartid.Text = itm.SubItems[2].Text;
                    BoxID = itm.SubItems[3].Text;
                    
                }
                else
                {

                }
            }
        }

        private void KasaKayitController_Load(object sender, EventArgs e)
        {
            list();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            listget();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            bool chk = _fboxService.Delete(BoxID);
            MessageBox.Show(chk.ToString());
            list();
        }

        private async void btnCardRead_Click(object sender, EventArgs e)
        {
            string cardcodetxt = txtKartid.Text.Trim();
            var readCard = _cartServices.GetByCardCode(cardcodetxt);
            if (readCard!=null)
            {
                CardID = readCard.Id;
                listget(readCard);
            }
            //_readerServices.openPort();

            //bool tagIsDefined = await _readerServices.checkTagIsDefined();

            //if (!tagIsDefined)
            //{
            //    await _readerServices.setTagIdToTextboxAsync(txtKartid);
            //}
            //else
            //{
            //    txtKartid.Text = InputEnums.CardIsDefined;
            //}
        }
    }
}
