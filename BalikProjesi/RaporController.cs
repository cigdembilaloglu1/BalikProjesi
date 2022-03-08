using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalikProjesi.Models;
using BalikProjesi.Services;
using Excel = Microsoft.Office.Interop.Excel;

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
        private  int ScreenW;
        private  int ScreenH;

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

        private void RBGun_CheckedChanged(object sender, EventArgs e)
        {
            TarihDetail.Visible = true;
            ComboDetail.Visible = false;

        }

        private void RBPersonel_CheckedChanged(object sender, EventArgs e)
        {
            TarihDetail.Visible = false;
            ComboDetail.Visible = true;
            DetailsearchLabel.Text = "Fileto Personeli: ";
            ComboDetail.Text = "Fileto Personeli Seçimi";
            var ComboPosition = DetailSearchCb.Location;
            DetailsearchLabel.Location = new Point(ComboPosition.X - DetailsearchLabel.Width, DetailsearchLabel.Location.Y);
            var FilletPersonel = _personelService.GetFilletPersonels();
            List<ComboBoxModel> Fp = new List<ComboBoxModel>();
            FilletPersonel.ForEach(x =>
            {
                Fp.Add(new ComboBoxModel
                {
                    Tag = x.Id,
                    Name = x.PersonelName + " " + x.PersonelSurname
                });
            });

            DetailSearchCb.DataSource = Fp;
            DetailSearchCb.ValueMember = "Tag";
            DetailSearchCb.DisplayMember = "Name";



        }

      

        private void RaporController_Load(object sender, EventArgs e)
        {
            
            
            //BaslangicDtP.Dock = DockStyle.Fill;
            //BitisDtP.Dock = DockStyle.Fill;
            StartDatePicker.Format = DateTimePickerFormat.Custom;
            StartDatePicker.CustomFormat = "dd.MM.yyyy   HH:mm:ss";
            EndDatePicker.Format = DateTimePickerFormat.Custom;
            EndDatePicker.CustomFormat = "dd.MM.yyyy   HH:mm:ss";

            var data = _recordingsService.Get().ToList().OrderBy(x => x.FilletOpeningDate).ToList();
            StartDatePicker.MaxDate = data.Last().FilletOpeningDate;
            StartDatePicker.MinDate = data.First().FilletOpeningDate;
            StartDatePicker.Value  = data.First().FilletOpeningDate;
            EndDatePicker.MinDate = data.First().FilletOpeningDate;

            var FilletPersonels = _personelService.GetFilletPersonels();
            var ControlPersonels = _personelService.GetControlPersonels();

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
                    KontrolPersonel = Kontrolcu.PersonelName + " " + Kontrolcu.PersonelSurname,
                    OdLekesi = x.OdLekesi,
                    KilcikDefo = x.FishBone,
                    HasatDefo = x.Defo,
                    FBasTar = x.FilletOpeningDate,
                    FBitTar = x.FilletClosingDate,
                    KBasTar = x.ControllerOpeningDate,
                    KBitTar = x.ControllerClosingDate,
                    KasaKod = Kasa.FishBoxCode,

                    KİsSure = kontrolSuresi,
                    FİsSure = filetoSuresi,



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
                Width = 45

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

                Width = 130
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 3,
                Name = "KasaKod",
                Text = "Kasa Kod",
                Width = 50
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 4,
                Name = "Bdefo",
                Text = "Bıçak Defo",
                Width = 40
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 5,
                Name = "Kdefo",
                Text = "Kılçık Defo",
                Width = 40
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 6,
                Name = "Hdefo",
                Text = "Hasat Defo",
                Width = 40
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 7,
                Name = "OdLeke",
                Text = "Öd Lekesi",
                Width = 40

            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 8,
                Name = "FBasTar",
                Text = "F.Başlangıç Tarihi",
                Width = 135
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 9,
                Name = "FBitTar",
                Text = "F.Bitiş Tarihi",
                Width = 135
            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 10,
                Name = "FİsSure",
                Text = "F.İşlem Süresi",
                Width = 100
            });

            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 11,
                Name = "KBasTar",
                Text = "K.Başlangıç tarihi",
                Width = 135

            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 12,
                Name = "KBitTar",
                Text = "K.Bitiş Tarihi",
                Width = 135

            });
            listView1.Columns.Add(new ColumnHeader
            {
                DisplayIndex = 13,
                Name = "KİsSure",
                Text = "K.İşlem Süresi",
                Width = 100


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
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "F.İşlem Süresi", Text = x.FİsSure.ToString() + " Saniye" });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.Başlangıç Tarihi", Text = x.KBasTar.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.Bitiş Tarihi", Text = x.KBitTar.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.İşlem Süresi", Text = x.KİsSure.ToString() + " Saniye" });

                listView1.Items.Add(ListItem);
            });


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcel_Click(object sender, EventArgs e, int i)
        {
            using (SaveFileDialog sfd=new SaveFileDialog() { Filter ="Excel |.xls",ValidateNames=true})
            {
                if (sfd.ShowDialog()== DialogResult.OK)
                {
                   Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
                   Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
                   Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                    uyg.Visible = false;
                    sayfa.Cells[1, 1] = "#";

                    sayfa.Cells[1, 2] = "Fileto Personel";
                    sayfa.Cells[1, 3] = "Kontrol Personel";



                }
            }
            //    Microsoft.Office.Interop.Excel.Application uyg = new Microsoft.Office.Interop.Excel.Application();
            //    uyg.Visible = true;
            //    Microsoft.Office.Interop.Excel.Workbook kitap = uyg.Workbooks.Add(System.Reflection.Missing.Value);
            //    Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            //    for (int i = 0; i < listView1.Columns.Count; i++)
            //    {
            //        Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
            //        range.Value2 = listView1.Columns[i].ListView.HeaderStyle;
            //    }
            //    for (int i = 0; i < listView1.Columns.Count; i++)
            //    {
            //        for (int j = 0; j < listView1.Items.Count; j++)
            //        {
            //            Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
            //            range.Value2 = listView1[i,j].Value;
            //            //Tarih ,Saat ve Ondalıklı sayılar için aşağıdaki formatları kullanabilirsiniz.

            //            //sayfa.Columns["E:E"].NumberFormat = "gg.aa.yyyy";
            //            //Tarih formatı E:E Excel deki sütunun adı
            //            sayfa.Columns["H:H"].NumberFormat = "dd.MM.yyyy   HH:mm:ss";//Tarih saat formatı
            //            //sayfa.Columns["F:F"].NumberFormat = "#,##0.00";
            //            //Ondalıklı Sayı Formatı

            //        }

            //    }


            //    //}
            /////

            }

        private void BaslangicDtP_ValueChanged(object sender, EventArgs e)
        {
            //BitisDtP.MinDate = BaslangicDtP.Value;

        }

        private void AraBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            if(LvModel.Count > 0)
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Fileto Personeli", typeof(string));
                table.Columns.Add("Kontrol Personeli", typeof(string));
                table.Columns.Add("Kasa Kodu", typeof(string));
                table.Columns.Add("Fileto Başlangıç", typeof(DateTime));
                table.Columns.Add("Fileto Bitiş", typeof(DateTime));
                table.Columns.Add("Fileto Çalışma Süresi", typeof(string));
                table.Columns.Add("Kontrol Başlangıç", typeof(DateTime));
                table.Columns.Add("Kontrol Bitiş", typeof(DateTime));
                table.Columns.Add("Kontrol Çalışma Süresi", typeof(string));
                table.Columns.Add("Hasat Defo", typeof(int));
                table.Columns.Add("Bıçak Defo", typeof(int));
                table.Columns.Add("Kılçık", typeof(int));
                table.Columns.Add("Öd Lekesi", typeof(int));

                LvModel.ForEach(x =>
                {
                    string Fcs = "";
                    int Fcsint = x.FİsSure / 60;
                    Fcs = Fcsint + " Dk";
                    string Kcs = "";
                    int Kcsint = x.KİsSure / 60;
                    Kcs = Kcsint + " Dk";
                    table.Rows.Add(
                        x.Id,
                        x.FiletoPersonel,
                        x.KontrolPersonel,
                        x.KasaKod,
                        x.FBasTar,
                        x.FBitTar,
                        Fcs,
                        x.KBasTar,
                        x.KBitTar,
                        Kcs,
                        x.HasatDefo,
                        x.BicakDefo,
                        x.KilcikDefo,
                        x.OdLekesi
                        );

                });

                var excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                var worKbooK = excel.Workbooks.Add(Type.Missing);
                var worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet; worKsheeT.Name = "LuckyfishRapor";

                worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 14]].Merge();
                worKsheeT.Cells[1, 1] = "LuckyFish Kontrol Tablosu Raporu";
                worKsheeT.Cells.Font.Size = 15;

                int rowcount = 2;
                dynamic celLrangE;
                foreach (DataRow datarow in table.Rows)
                {
                    rowcount += 1;
                    for (int i = 1; i <= table.Columns.Count; i++)
                    {

                        if (rowcount == 3)
                        {
                            worKsheeT.Cells[2, i] = table.Columns[i - 1].ColumnName;
                            worKsheeT.Cells.Font.Color = System.Drawing.Color.Black;

                        }

                        worKsheeT.Cells[rowcount, i] = datarow[i - 1].ToString();

                        if (rowcount > 3)
                        {
                            if (i == table.Columns.Count)
                            {
                                if (rowcount % 2 == 0)
                                {
                                    celLrangE = worKsheeT.Range[worKsheeT.Cells[rowcount, 1], worKsheeT.Cells[rowcount, table.Columns.Count]];
                                }

                            }
                        }

                    }
                }

                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[rowcount, table.Columns.Count]];
                celLrangE.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = celLrangE.Borders;
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[2, table.Columns.Count]];
                object misValue = System.Reflection.Missing.Value;

                worKbooK.SaveAs("c:\\excel\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                //worKbooK.SaveAs(@"C:\\excel\\Rapor" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm") +".xls"); ;
                worKbooK.Close();
                excel.Quit();
            }
        }

        private void PanelBoyutlandırma(object sender, EventArgs e)
        {
            ScreenW = this.AnaPanel.Width;
            ScreenH = this.AnaPanel.Height;
            // listView1 Column Width.
            //var ColumnList = listView1.Columns;
            //int SingleWidth = ScreenW / 14;
            int[] WidthArray = new int[] { 45, 110, 110, 80, 80, 80, 80, 80, 130, 130, 130, 130, 100, 100 };
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                int ColWidth = WidthArray[i];
                int NewColWidth = WidthPercenter(ColWidth);
                listView1.Columns[i].Width = NewColWidth;
            }
        }
        private int WidthPercenter(int Source)
        {
            int CalculatedBase = 0;
            if (ScreenW < 1200)
                CalculatedBase = 1200;
            else
                CalculatedBase = ScreenW;

            //int CalculatedSize = 1255;
            float CurrentSizeBalance =  ((1200 * 100) / CalculatedBase);
            var NewSource = ((Source / 100) * CurrentSizeBalance) + Source;
            int CalculatedSizeBalance = int.Parse(Math.Round(NewSource, 0).ToString());

            return CalculatedSizeBalance;
        }

        private void RBKontrol_CheckedChanged(object sender, EventArgs e)
        {
            TarihDetail.Visible = false;
            ComboDetail.Visible = true;

            DetailsearchLabel.Text = "Kontrol Personeli: ";
            var ComboPosition = DetailSearchCb.Location;
            DetailsearchLabel.Location = new Point(ComboPosition.X - DetailsearchLabel.Width, DetailsearchLabel.Location.Y);
            ComboDetail.Text = "Kontrol Personeli Seçimi";

            var ControlPersonel = _personelService.GetControlPersonels();
            List<ComboBoxModel> Cp = new List<ComboBoxModel>();
            ControlPersonel.ForEach(x =>
            {
                Cp.Add(new ComboBoxModel
                {
                    Tag = x.Id,
                    Name = x.PersonelName + " " + x.PersonelSurname
                });
            });

            DetailSearchCb.DataSource = Cp;
            DetailSearchCb.ValueMember = "Tag";
            DetailSearchCb.DisplayMember = "Name";
        }

        private void KasaBtn_CheckedChanged(object sender, EventArgs e)
        {
            TarihDetail.Visible = false;
            ComboDetail.Visible = true;

            DetailsearchLabel.Text = "Kasa : ";
            ComboDetail.Text = "Kasa Seçimi";
            var ComboPosition = DetailSearchCb.Location;
            DetailsearchLabel.Location = new Point(ComboPosition.X - DetailsearchLabel.Width, DetailsearchLabel.Location.Y);

            var Cases = _fboxService.GetAllBoxes();
            List<ComboBoxModel> Case = new List<ComboBoxModel>();
            Cases.ForEach(x =>
            {
                Case.Add(new ComboBoxModel
                {
                    Tag = x.Id,
                    Name = x.FishBoxCode + " -" + x.FishBoxType
                });
            });

            DetailSearchCb.DataSource = Case;
            DetailSearchCb.ValueMember = "Tag";
            DetailSearchCb.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var NewLvModel = new List<RaporListviewModel>();
            if (RBGun.Checked)
            {
                int RecordId = 1;
                string Tp = string.Empty;
                if (KayitTarihi.Checked)
                    Tp = "Kayit";
                else if (FiletoTarihi.Checked)
                    Tp = "Fileto";
                else if (KontrolTarihi.Checked)
                    Tp = "Kontrol";
                var Results = _recordingsService.TarihArama(StartDatePicker.Value, EndDatePicker.Value, Tp);
                Results.ForEach(x =>
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
                    NewLvModel.Add(new RaporListviewModel
                    {
                        Id = RecordId,
                        BicakDefo = x.Knife,
                        FiletoPersonel = Filetocu.PersonelName + " " + Filetocu.PersonelSurname,
                        KontrolPersonel = Kontrolcu.PersonelName + " " + Kontrolcu.PersonelSurname,
                        OdLekesi = x.OdLekesi,
                        KilcikDefo = x.FishBone,
                        HasatDefo = x.Defo,
                        FBasTar = x.FilletOpeningDate,
                        FBitTar = x.FilletClosingDate,
                        KBasTar = x.ControllerOpeningDate,
                        KBitTar = x.ControllerClosingDate,
                        KasaKod = Kasa.FishBoxCode,

                        KİsSure = kontrolSuresi,
                        FİsSure = filetoSuresi,



                    });
                    RecordId++;
                });
            }
            else if (RBPersonel.Checked)
            {

            }
            else if (RBKontrol.Checked)
            {

            }
            else if (KasaBtn.Checked)
            {

            }

            listView1.Items.Clear();
            NewLvModel.ForEach(x =>
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
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "F.İşlem Süresi", Text = x.FİsSure.ToString() + " Saniye" });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.Başlangıç Tarihi", Text = x.KBasTar.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.Bitiş Tarihi", Text = x.KBitTar.ToString() });
                ListItem.SubItems.Add(new ListViewItem.ListViewSubItem { Name = "K.İşlem Süresi", Text = x.KİsSure.ToString() + " Saniye" });

                listView1.Items.Add(ListItem);
            });
        }
    }
}
