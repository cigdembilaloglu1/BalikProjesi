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
    public partial class FiletoTeslim : UserControl
{
        private readonly IPersonelServices _perService;
        private readonly ICartsServices1 _cartsServices;
        private readonly ReaderServices _readerServices;
        private string persID;
        private string persName;
        private string persSurname;

        private string CardID;
        private string PersTuru;
        public FiletoTeslim()
        {
            InitializeComponent();
          
            _perService = new PersonelServices();
            _readerServices = new ReaderServices();
            _cartsServices = new CartsServices();
            persID = "";
            CardID = "";
            PersTuru = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilletUser FilUs = new FilletUser();
            FilUs.Show();
            this.Hide();
        }

        private async Task FiletoTeslim_LoadAsync(object sender, EventArgs e)
        {
            await _readerServices.WriteTagIdToTextboxAsync(txtKartID);
            label2.Text = persName+" "+ persSurname +"TARAFINDAN FİLETO TESLİM İŞLEMİ GERÇEKLEŞMİŞTİR.LÜTFEN KASA KARTINIZI OKUTUNUZ.";

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
