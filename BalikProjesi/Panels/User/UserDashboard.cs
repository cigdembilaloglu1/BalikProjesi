using BalikProjesi.Forms.User;
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
    public partial class UserDashboard : UserControl
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void FletoPanelBtn_Click(object sender, EventArgs e)
        {
            FiletoDashboard fd = new FiletoDashboard();
            this.Controls.Clear();
            this.Controls.Add(fd);  
            fd.Dock= DockStyle.Fill;
            fd.Show();
        }

        private void KontrolBtn_Click(object sender, EventArgs e)
        {
            ControlDashboard cd = new ControlDashboard();
            this.Controls.Clear();
            this.Controls.Add(cd);
            cd.Dock = DockStyle.Fill;
            cd.Show();
        }
    }
}
