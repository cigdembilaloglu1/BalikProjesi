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
    public partial class FiletoKaydiBitir : UserControl
    {
        public FiletoKaydiBitir()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            FiletoDashboard Ud = new FiletoDashboard();
            this.Controls.Add(Ud);
            Ud.Dock = DockStyle.Fill;
            Ud.Show();
        }
    }
}
