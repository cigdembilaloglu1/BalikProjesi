﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalikProjesi.Models;
using BalikProjesi.Services;

namespace BalikProjesi
{
    public partial class RaporController : UserControl
    {
        private readonly IRecordingsServices _recordingsService;
        private readonly ICartsServices1 _cartService;
        private readonly ReaderServices _readerServices;
        private readonly IPersonelServices _personelService;
        private readonly IFishBoxServices _fboxService;
        private readonly List<RaporListviewModel> LvModel;
        public RaporController()
        {
            InitializeComponent();
            _recordingsService = new RecordingsServices();
            _cartService = new CartsServices();
            _readerServices = new ReaderServices();
            _personelService = new PersonelServices();
            _fboxService = new FishBoxServices();
            LvModel = new List<RaporListviewModel>();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KontrollerTLP_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void RBGun_CheckedChanged(object sender, EventArgs e)
        {
           
            PersLb.Visible = false;
            KasaLb.Visible = false;
            PersCb.Visible = false;
            KasaCb.Visible = false;
        }

        private void RBPersonel_CheckedChanged(object sender, EventArgs e)
        {

            PersLb.Visible = true;
            KasaLb.Visible = false;
            PersCb.Visible = true;
            KasaCb.Visible = false;
           

        }

        private void RBKasa_CheckedChanged(object sender, EventArgs e)
        {
            
            PersLb.Visible =false;
            KasaLb.Visible = true;
            PersCb.Visible =false;
            KasaCb.Visible = true;


        }

        private void LbArama_Click(object sender, EventArgs e)
        {

        }

        private void PersLb_Click(object sender, EventArgs e)
        {

        }

        private void RaporController_Load(object sender, EventArgs e)
        {
            PersLb.Visible = false;
            KasaLb.Visible = false;
            PersCb.Visible = false;
            KasaCb.Visible = false;

            var data = _recordingsService.Get().ToList().OrderBy(x=>x.FilletOpeningDate).ToList();
            BaslangicDtP.MaxDate = data.Last().FilletOpeningDate;
            BaslangicDtP.MinDate = data.First().FilletOpeningDate;
            BitisDtP.MinDate = data.First().FilletOpeningDate;
            int RecordId = 1;
            data.ForEach(x =>
            {
                int filetoSuresi = 0;
                var filetoFarki = x.FilletClosingDate - x.FilletOpeningDate;
                filetoSuresi = int.Parse(filetoFarki.TotalSeconds.ToString());

                int kontrolSuresi = 0;
                var kontrolFarki = x.ControllerClosingDate - x.ControllerOpeningDate;
                kontrolSuresi = int.Parse(kontrolFarki.TotalSeconds.ToString());


                var Filetocu = _personelService.GetFilletPersonnelByCardId(x.FilletCardId);
                var Kontrolcu = _personelService.GetControlPersonnelByCardId(x.ControllerCardId);
                var Kasa = _fboxService.Get(x.FishboxID);
                LvModel.Add(new RaporListviewModel
                {
                    Id = RecordId,
                    BicakDefo = x.Knife,
                    FiletoPersonel = Filetocu.PersonelName + " " + Filetocu.PersonelSurname,
                    KontrolPersonel=Kontrolcu.PersonelName+" "+Kontrolcu.PersonelSurname,
                    OdLekesi=x.OdLekesi,
                    KilcikDefo=x.FishBone,
                    HasatDefo=x.Defo,
                    FBasTar=x.FilletOpeningDate,
                    FBitTar=x.FilletClosingDate,
                    KBasTar=x.ControllerOpeningDate,
                    KBitTar=x.ControllerClosingDate,
                    KasaKod=Kasa.FishBoxCode,

                    KİsSure=kontrolSuresi,
                    FİsSure=filetoSuresi,



                });
                RecordId++;
            });
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 0,
                Name = "ID",
                Text = "#",
                 Width=100
                
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 1,
                Name = "Fper",
                Text = "Fileto Personel",
                Width = 130
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 2,
                Name = "Cper",
                Text = "Kontrol Personel",
                
                Width = 140
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 3,
                Name = "KasaKod",
                Text = "Kasa Kod",
                Width = 110
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 4,
                Name = "Bdefo",
                Text = "Bıçak Defo",
                Width = 120
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 5,
                Name = "Kdefo",
                Text = "Kılçık Defo",
                Width = 121
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 6,
                Name = "Hdefo",
                Text = "Hasat Defo",
                Width = 122
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 7,
                Name = "OdLeke",
                Text = "Öd Lekesi",
                Width = 123

            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 8,
                Name = "FBasTar",
                Text = "F.Başalngıç Tarihi"
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 9,
                Name = "FBitTar",
                Text = "F.Bitiş Tarihi",
                Width = 136
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 10,
                Name = "FBİsSure",
                Text = "F.İşlem Süresi",
                Width = 140
            });
           
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 11,
                Name = "KBasTar",
                Text = "K.Başlangıç tarihi",
                Width = 137

            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 12,
                Name = "KBitTar",
                Text = "K.Bitiş Tarihi",
                Width = 138

            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 13,
                Name = "KİsSure",
                Text = "K.İşlem Süresi",
                Width = 141


            });


            LvModel.ForEach(x =>
            {
                var ListItem = new ListViewItem();
                ListItem.Text = x.Id.ToString();
                ListItem.Tag = x.Id;
                //ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name= "#", Text = x.Id.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Fileto Personel", Text = x.FiletoPersonel });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Kontrol Personel", Text = x.KontrolPersonel });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Kasa Kod", Text = x.KasaKod });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Bıçak Defo", Text = x.BicakDefo.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Kılçık Defo", Text = x.KilcikDefo.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Hasat Defo", Text = x.HasatDefo.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "Öd Lekesi", Text = x.OdLekesi.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "F.Başlangıç Tarihi", Text = x.FBasTar.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "F.Bitiş Tarihi", Text = x.FBitTar.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "F.İşlem Süresi", Text = x.FİsSure.ToString() +" Saniye" });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.Başlangıç Tarihi", Text = x.KBasTar.ToString()  });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.Bitiş Tarihi", Text = x.KBitTar.ToString()  });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.İşlem Süresi", Text = x.KİsSure.ToString() + " Saniye"  });

                listView1.Items.Add(ListItem);
            });
            /// LvModeldeki Veriyi ListViewa Bınd Et. 
            //string BoxCode, BoxType, BoxcardId;
            //if (listView1.Items.Count > 0)
            //{
            //    listView1.Items.Clear();
            //}
            //var dt = _fboxService.Get(currentPage);
            //foreach (var item in dt)
            //{
            //    BoxID = item.Id;
            //    BoxcardId = item.CartCode;
            //    BoxCode = item.FishBoxCode;
            //    BoxType = item.FishBoxType;


            //    string[] data = { BoxcardId, BoxCode, BoxType, BoxID };
            //    ListViewItem record = new ListViewItem(data);
            //    listView1.Items.Add(record);
            //}
            //string ID,FiletoPersonel, KontrolPersonel, KasaKod;
            //int BicakDefo, Kilcikdefo, HasatDefo, OdLekesi,FİsTar,KİsTar;
            //DateTime FbasTar, FBitTar, kBasTar, KBitTar;
            //if (listView1.Items.Count > 0)
            //{
            //    listView1.Items.Clear();
            //}
            //var dt = _recordingsService.Get();
            //foreach(var item in dt)
            //{
            //    ID = item.Id;
            //    BicakDefo = item.Knife;
            //    Kilcikdefo = item.FishBone;
            //    HasatDefo = item.Defo;
            //    OdLekesi = item.OdLekesi;
            
            //}
            //var fpers = _personelService.GetFilletPersonels();
            //foreach(var item in fpers)
            //{
            //    FiletoPersonel = item.PersonelName + " " + item.PersonelSurname;
            //    FbasTar = item.OpeningDate;
            //    FBitTar = item.ClosingDate;

            //}
            //var cpers = _personelService.GetControlPersonels();
            //foreach(var item in cpers)
            //{
            //    KontrolPersonel = item.PersonelName + " " + item.PersonelSurname;
            //    kBasTar = item.OpeningDate;
            //    KBitTar = item.ClosingDate;

            //}
            //string[] data = { ID, FiletoPersonel, KontrolPersonel, KasaKod, BicakDefo, Kilcikdefo, HasatDefo, OdLekesi, FİsTar, KİsTar;
            //DateTime FbasTar, FBitTar, kBasTar, KBitTar, FbasTar, FBitTar, kBasTar, KBitTar);
        
            //   ListViewItem record = new ListViewItem(data);
            //   listView1.Items.Add(record);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {

        }

        private void BaslangicDtP_ValueChanged(object sender, EventArgs e)
        {
            BitisDtP.MinDate = BaslangicDtP.Value;
        }
    }
}
