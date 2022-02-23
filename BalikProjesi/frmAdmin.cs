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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void Kapat(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            var rprController = new RaporController();
            MainPanel.Controls.Add(rprController);  
            rprController.Show();
            rprController.Dock = DockStyle.Fill;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void kARTKAYDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var kartKayitController = new KartKayitController();
            MainPanel.Controls.Add(kartKayitController);
            kartKayitController.Show();
            kartKayitController.Dock = DockStyle.Fill;  
        }

        private void pERSONELKAYDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var kartKayitController = new PersonlKayitController();
            MainPanel.Controls.Add(kartKayitController);
            kartKayitController.Show();
            kartKayitController.Dock = DockStyle.Fill;
        }

        private void kASAKAYDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            var kartKayitController = new KasaKayitController();
            MainPanel.Controls.Add(kartKayitController);
            kartKayitController.Show();
            kartKayitController.Dock = DockStyle.Fill;

        }

        private void rAPORToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
