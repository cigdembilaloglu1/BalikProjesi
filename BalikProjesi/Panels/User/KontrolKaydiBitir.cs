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
    public partial class KontrolKaydiBitir : UserControl
    {
        public KontrolKaydiBitir()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ControlDashboard Ud = new ControlDashboard();
            this.Controls.Add(Ud);
            Ud.Dock = DockStyle.Fill;
            Ud.Show();
        }
        private void selections(object sender, EventArgs e)
        {
            frmNumbers frm = new frmNumbers();

            if (((Button)sender).Name == "HasatDefoBtn")
            {
                frm.formValue = HasatDefoTxt.Text;
                frm.screenLabel.Text = HasatDefoTxt.Text;
                frm.ShowDialog();
                HasatDefoTxt.Text = frm.formValue.Trim();
            }
            else if (((Button)sender).Name == "KılcıkBtn")
            {
                frm.formValue = KılcıkTxt.Text;
                frm.screenLabel.Text = KılcıkTxt.Text;
                frm.ShowDialog();
                KılcıkTxt.Text = frm.formValue.Trim();
            }
            else if (((Button)sender).Name == "BıcakDefoBtn")
            {
                frm.formValue = BıcakDefoTxt.Text;
                frm.screenLabel.Text = BıcakDefoTxt.Text;
                frm.ShowDialog();
                BıcakDefoTxt.Text = frm.formValue.Trim();
            }
            else if (((Button)sender).Name == "DigerBtn")
            {
                frm.formValue = DigerTxt.Text;
                frm.screenLabel.Text = DigerTxt.Text;
                frm.ShowDialog();
                DigerTxt.Text = frm.formValue.Trim();

            }
        }

        private void RaporBtn_Click(object sender, EventArgs e)
        {
            PopUp popup = new PopUp();
            popup.label3.Text = HasatDefoTxt.Text + " adet hasat defo elde edildi.";
            popup.label4.Text = KılcıkTxt.Text + " adet kılçık elde edildi.";
            popup.label5.Text = BıcakDefoTxt.Text + " adet bıçak defo elde edildi.";
            popup.label6.Text = DigerTxt.Text + " adet diğer ürün elde edildi.";
            popup.Show();
        }
    }
       
}
