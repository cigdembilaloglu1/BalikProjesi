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
            KontrolTeslim Kteslim = new KontrolTeslim();
            Kteslim.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KontrolKabul Kkabul = new KontrolKabul();
            Kkabul.Show();
            this.Hide();
        }
    }
}
