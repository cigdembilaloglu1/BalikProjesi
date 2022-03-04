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
    public partial class ControlDashboard : UserControl
    {
        public ControlDashboard()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UserDashboard Ud = new UserDashboard();
            this.Controls.Add(Ud);
            Ud.Dock = DockStyle.Fill;
            Ud.Show();
        }

        private void KontrolKaydiBasla_Click(object sender, EventArgs e)
        {
            KontrolKaydiBaslat fkd = new KontrolKaydiBaslat();
            this.Controls.Clear();
            this.Controls.Add(fkd);
            fkd.Dock = DockStyle.Fill;
            fkd.Show();
        }

        private void KontrolKayitBitir_Click(object sender, EventArgs e)
        {
            KontrolKaydiBitir fkd = new KontrolKaydiBitir();
            this.Controls.Clear();
            this.Controls.Add(fkd);
            fkd.Dock = DockStyle.Fill;
            fkd.Show();

        }
    }
}
