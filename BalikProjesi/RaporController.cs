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
    public partial class RaporController : UserControl
    {
        public RaporController()
        {
            InitializeComponent();
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
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
