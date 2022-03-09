using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalikProjesi.Services;


namespace BalikProjesi
{
    public partial class Temp : Form

    {
        private readonly ICartsServices1 _cartService;
        private readonly IPersonelServices _personelService;
        private readonly IFishBoxServices _fboxService;
        private readonly IRecordingsServices _recordingsService;

        public Temp()
        {
            InitializeComponent();
            _recordingsService = new RecordingsServices();
            _cartService = new CartsServices();
            _fboxService = new FishBoxServices();
            _personelService = new PersonelServices();
        }
        //public void liste()
        //{
        //    string PerAd, PerSoyad, Gorev, KasaKod, BıcakD, KilcikD, HasatD, Dİger, BasTar, BitisTar, İslemSüresi;


        //}

        private void Temp_Load(object sender, EventArgs e)
        {
            var filetocular = _personelService.GetFilletPersonels();
            int FiletoCount = filetocular.Count() -1;
            var kontrolculer = _personelService.GetControlPersonels();
            int KontrolcuCount = kontrolculer.Count() -1;
            var kasalar = _fboxService.GetAllBoxes();
            int KasaCount = kasalar.Count() -1;

            for(int i =0; i< 10000; i++)
            {
                Random rnd = new Random();
                int FiletocuIndex = rnd.Next(FiletoCount);
                var Filetocu = filetocular[FiletocuIndex];

                int KontrolcuIndex = rnd.Next(KontrolcuCount);
                var Kontrolcu = kontrolculer[KontrolcuIndex];
                
                int KasaIndex = rnd.Next(KasaCount);
                var Kasa = kasalar[KasaIndex];

                DateTime FiletoBaslangic = DateTime.Now.AddMinutes(rnd.Next(1, 10));
                DateTime FiletoBitis = FiletoBaslangic.AddMinutes(rnd.Next(5, 15));

                DateTime KontrolBaslangic = FiletoBitis.AddMinutes(rnd.Next(1, 10));
                DateTime KontrolBitis = KontrolBaslangic.AddMinutes(rnd.Next(5, 15));

                int HasatDefo = rnd.Next(0, 15);
                int Kilcik = rnd.Next(0, 15);
                int Bicak = rnd.Next(0, 15);
                int OdLekesi = rnd.Next(0, 15);

                var kayit = _recordingsService.Create(new Entities.Recordings
                {
                    ControllerCardId = Kontrolcu.CartId,
                    ControllerClosingDate = KontrolBitis,
                    ControllerID = Kontrolcu.Id,
                    ControllerOpeningDate = KontrolBaslangic,
                    ControlStatus = true,
                    CreateDate = FiletoBaslangic.AddSeconds(0),
                    Defo = HasatDefo,
                    FishBone = Kilcik,
                    FilletCardId = Filetocu.CartId,
                    FilletClosingDate = FiletoBitis,
                    FilletID = Filetocu.Id,
                    Knife = Bicak,
                    OdLekesi = OdLekesi,
                    FishboxStatus = true,
                    FilletStatus = true,
                    FishboxID = Kasa.Id,
                    FilletOpeningDate = FiletoBaslangic

                });

            }
        }
    }
}
