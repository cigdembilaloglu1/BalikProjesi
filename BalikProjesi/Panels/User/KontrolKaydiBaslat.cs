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
    public partial class KontrolKaydiBaslat : UserControl
    {
        public KontrolKaydiBaslat()
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
    }
}
