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
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
        }
        void ShowPopup(string text, int width, int height)
        {
            // Popup adında bir form oluştur
            Form Popup = new Form
            {
                Width = width, // genişlik parametresini ata
                Height = height, // yükseklik parametresini ata
                ShowInTaskbar = false, // başlat çubuğunda görünme
                FormBorderStyle = FormBorderStyle.None, // Form kenarlıkları olmasın
                BackColor = Color.CornflowerBlue, // Arkaplan "Mısır çiçeği mavisi" rengi
                StartPosition = FormStartPosition.CenterScreen, // Formu ekrana ortala
                TopMost = true, // Her zaman üstte
                Cursor = Cursors.Hand // İmleç, el şeklinde olsun
            };

            // Form click eventi
            Popup.Click += delegate {
                this.Dispose(); // tıklanıldığında formu kapat
            };

            // Form içi grafik işlemleri
            Popup.Paint += delegate {
                // Formun etrafına bir dörtgen çiz (Rengi siyah = Pens.Black)
                Popup.CreateGraphics().DrawRectangle(Pens.Black, 0, 0, (width - 1), (height - 1));
            };

            // lbl_text adında bir label oluştur
            Label lbl_text = new Label
            {
                Left = 30, // sol tarafa uzaklık 30 pixel
                Top = 30, // yukarıya uzaklık 30 pixel
                AutoSize = true, // label boyutunu text'e göre  ayarla
                Font = new Font(this.Font, FontStyle.Bold), // font kalın olsun
                Text = text // metin parametresini ata
            };

            // oluşturulan labeli forma ekle
            Popup.Controls.Add(lbl_text);

            // pop-up formu göster
            Popup.ShowDialog();
        }
        private void PopUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
 