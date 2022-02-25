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

        private void KontrolKabul_Load(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            ControlUser ContUs = new ControlUser();
            ContUs.Show();
            this.Hide();
        }
    }
}
