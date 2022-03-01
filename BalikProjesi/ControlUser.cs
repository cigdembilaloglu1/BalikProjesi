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
    public partial class ControlUser : Form
    {
        public ControlUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontolStart Kteslim = new KontolStart();
            Kteslim.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontolExit Kkabul = new KontolExit();
            Kkabul.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUser fuser = new frmUser();
            fuser.Show();
            this.Hide();

        }
    }
}
