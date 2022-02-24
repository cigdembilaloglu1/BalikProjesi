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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilletUser Fillet=new FilletUser();
            
            Fillet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlUser Control = new ControlUser();
           
             Control.Show();
             this.Hide();
        }

        //private void fİLETOPERSONELİToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MainPanel.Controls.Clear();
        //    var FilletUser = new FilletUser();
        //    MainPanel.Controls.Add(FilletUser);
        //    FilletUser.Show();
        //    FilletUser.Dock = DockStyle.Fill;
        //}

        //private void kONTROLPERSONELİToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MainPanel.Controls.Clear();
        //    var ControlUser = new ControlUser();
        //    MainPanel.Controls.Add(ControlUser);
        //    ControlUser.Show();
        //    ControlUser.Dock = DockStyle.Fill;
        //}
    }
}
