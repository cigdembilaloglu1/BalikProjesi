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
    public partial class KontrolKabul : Form
    {
        public KontrolKabul()
        {
            InitializeComponent();
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    PopUp popup=new PopUp();
        //    popup.Show();

        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
                 PopUp popup = new PopUp();
                 popup.Show();
        }

        private void selections(object sender, EventArgs e)
        {
            frmNumbers frm = new frmNumbers();

            if (((Button)sender).Text == "HASAT  DEFO")
            {
                frm.formValue = textBox1.Text;
                frm.screenLabel.Text = textBox1.Text;
                frm.ShowDialog();
                textBox1.Text = frm.formValue;
            }
            else if (((Button)sender).Text == "KILÇIK")
            {
                frm.formValue = textBox2.Text;
                frm.screenLabel.Text = textBox2.Text;
                frm.ShowDialog();
                textBox2.Text = frm.formValue;
            }
            else if (((Button)sender).Text == "BIÇAK DEFO")
            {
                frm.formValue = textBox3.Text;
                frm.screenLabel.Text = textBox3.Text;
                frm.ShowDialog();
                textBox3.Text = frm.formValue;
            }
            else if (((Button)sender).Text == "+")
            {
                frm.formValue = textBox4.Text;
                frm.screenLabel.Text = textBox4.Text;
                frm.ShowDialog();
                textBox4.Text = frm.formValue;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
