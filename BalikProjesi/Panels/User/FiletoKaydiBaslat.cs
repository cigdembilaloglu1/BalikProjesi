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

namespace BalikProjesi.Panels.User
{
    public partial class FiletoKaydiBaslat : UserControl
    {
        public string KasaKarti;
        public string FiletoPersonelKarti;
        private readonly IPersonelServices _persoelService;
        private readonly IFishBoxServices _fishboxService;
        private readonly ICartsServices1 _cartService;
        private readonly IRecordingsServices _recordingsService;
        private readonly ReaderServices _readerServices;

        private bool KasaKartiOkuma = false;
        private bool PersonelKartiOkuma = false;
        public FiletoKaydiBaslat()
        {
            _persoelService = new PersonelServices();
            _fishboxService = new FishBoxServices();
            _cartService = new CartsServices();
            _recordingsService = new RecordingsServices();
            _readerServices = new ReaderServices();
            InitializeComponent();
        }

        private void FletoKaydiBaslat_Load(object sender, EventArgs e)
        {
            while (KasaKartiOkuma)
            {
                CheckKasaKartiStatus();
            }
        }

        private async void CheckKasaKartiStatus()
        {
            while (string.IsNullOrEmpty(KasaKarti))
            {
                KasaKarti = await _readerServices.GetTagId();
            }
            /// Okunan Kasa Kartı Bir KASAYA mı Ait diye KASA Tablosunda kontrol edilir. 
            /// Eğer Kasaya aitse ID si alınır. 
            /// Recordins içinde KASA ID si eşleşen TAMAMLANMAMIŞ Kayıt var ise Kayda ait bilgiler getirilir. ve kullanıcı uyarılır. 
            /// Tamamlanmış bir kayıt varsa yeni kayıt açmak için PERSONEL Kartı da istenir.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            FiletoDashboard Ud = new FiletoDashboard();
            this.Controls.Add(Ud);
            Ud.Dock = DockStyle.Fill;
            Ud.Show();
        }

        private void FiletoKayitTLP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtnTLP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void messageTLP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
