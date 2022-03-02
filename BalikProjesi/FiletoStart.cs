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
using BalikProjesi.Services;
using BalikProjesi.Enums;
using BalikProjesi.Models;

namespace BalikProjesi
{
    public partial class FiletoStart : Form

    {
        public Recordings rc=new Recordings();
        
        private readonly ICartsServices1 _cartsServices;
        private readonly IPersonelServices _personelServices;
        private readonly IFishBoxServices _fishBoxServices;
        string FilletID;
        string FilletCardId;
        string FishboxID;



        public FiletoStart()
        {
            InitializeComponent();
            _cartsServices = new CartsServices();
            _personelServices = new PersonelServices();
            _fishBoxServices = new FishBoxServices();

        }

        public InfoPanellReturnModel FishBoxInfo()
        {
            var ReturnModel = new InfoPanellReturnModel();
            return ReturnModel;
             FishboxID = "";

            var result = _fishBoxServices.CheckRecordValidByFishboxID(FishboxID);

            if (result != null)
            {
                ReturnModel.Kayitlar = result;


                // Kayıt Kapatılmamış bu nedenle
                // Kasa Kodu, Kaydı Açık kalan Personel Bilgisi 
                // ve Kapatma yazısı ekranda belirmeli. 


                // FishboxID = result.Eq(FishboxID);
               //   FishboxID = result.Equals(ID);

               

            }
            else
            {
                //kapanmamış kayıt var kontrolcüden
            }

        }
        void PersonelInfo()

        {
            FilletID = "";
            FilletCardId = "";
            var result = _personelServices.CheckPersonelValidByPeronelID(FilletID);
            if (result != null)
            {


            }
            else
            { //kaydı açan personel kapatan personel değil

            }
        }

        void CreateRecordings()
        {
            Recordings kayit = new Recordings();
            rc.FilletID = kayit.FilletID;
            rc.FilletCardId=kayit.FilletCardId;
            rc.FishboxID=kayit.FishboxID;
            rc.FilletOpeningDate = DateTime.Now;
            rc.CreateDate = DateTime.Now;


        }
        //void CloseRecordings()
        //{
        //    Recordings kayit = new Recordings();
        //    rc.FilletClosingDate= DateTime.Now;
        //}

        private void button1_Click(object sender, EventArgs e)
            {
                FilletUser FillUs = new FilletUser();
                FillUs.Show();
                this.Hide();
            }

            private void FiletoStart_Load(object sender, EventArgs e)
            {
                label2.Text = RecordingEnums.ReadFishbox;
                label1.Text = "";
                label3.Text = "";

            }
        
    }
}
