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
    public partial class frmNumbers : Form
    {
        public string formValue= "";
        public frmNumbers()
        {
            InitializeComponent();
        }

        private void numberKeys(object sender, EventArgs e)
        {
            if (screenLabel.Text == "0")
            {
                screenLabel.Text = "";
            }

            screenLabel.Text += ((Button)sender).Text;
        }

        private void deleteKey_Click(object sender, EventArgs e)
        {
                screenLabel.Text = screenLabel.Text.Substring(0, screenLabel.Text.Length - 1);

            if (screenLabel.Text == "")
            {
                screenLabel.Text = "0";
            }
        }
        
        private void clearKey_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";
        }

        private void submitKey_Click(object sender, EventArgs e)
        {   
           
            formValue = screenLabel.Text;
            this.Close();
        }

        private void cancelKey_Click(object sender, EventArgs e)
        {
            if (formValue == screenLabel.Text)
            {
                formValue = screenLabel.Text;
            }

            this.Close();
        }
    }
}
