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
    public partial class KontolExit : Form
    {
        public KontolExit()
        {
            InitializeComponent();
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    PopUp popup=new PopUp();
        //    popup.Show();

        //}

        
        private void selections(object sender, EventArgs e)
        {
            frmNumbers frm = new frmNumbers();

            if (((Button)sender).Name == "btnHasatDefo")
            {
                frm.formValue = textBox1.Text;
                frm.screenLabel.Text = textBox1.Text;
                frm.ShowDialog();
                textBox1.Text = frm.formValue.Trim();
            }
            else if (((Button)sender).Name == "btnKilcik")
            {
                frm.formValue = textBox2.Text;
                frm.screenLabel.Text = textBox2.Text;
                frm.ShowDialog();
                textBox2.Text = frm.formValue.Trim();
            }
            else if (((Button)sender).Name == "btnBicakDefo")
            {
                frm.formValue = textBox3.Text;
                frm.screenLabel.Text = textBox3.Text;
                frm.ShowDialog();
                textBox3.Text = frm.formValue.Trim();
            }
            else if (((Button)sender).Name == "btnDiger")
            {
                frm.formValue = textBox4.Text;
                frm.screenLabel.Text = textBox4.Text;
                frm.ShowDialog();
                textBox4.Text = frm.formValue.Trim();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PopUp popup = new PopUp();
            popup.label3.Text = textBox1.Text + " adet hasat defo elde edildi." ;
            popup.label4.Text = textBox2.Text + " adet kılçık elde edildi." ;
            popup.label5.Text = textBox3.Text + " adet bıçak defo elde edildi." ;
            popup.label6.Text = textBox4.Text + " adet diğer ürün elde edildi." ;
            popup.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            ControlUser fuser = new ControlUser();
            fuser.Show();
            this.Close();
        }
    }
}
