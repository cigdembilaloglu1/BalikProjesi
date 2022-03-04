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
    public partial class FiletoDashboard : UserControl
    {
        public FiletoDashboard()
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

        private void FiletoDashboardTLP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FiletoKaydiBasla_Click(object sender, EventArgs e)
        {
            FiletoKaydiBaslat fkd = new FiletoKaydiBaslat();
            this.Controls.Clear();
            this.Controls.Add(fkd);
            fkd.Dock = DockStyle.Fill;
            fkd.Show();
        }

        private void FiletoKayitBitir_Click(object sender, EventArgs e)
        {
            FiletoKaydiBitir fkd = new FiletoKaydiBitir();
            this.Controls.Clear();
            this.Controls.Add(fkd);
            fkd.Dock = DockStyle.Fill;
            fkd.Show();
        }
    }
}
