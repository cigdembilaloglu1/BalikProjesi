using BalikProjesi.Panels.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalikProjesi.Forms.User
{
    public partial class MainUser : Form
    {
        public MainUser()
        {
            InitializeComponent();
        }

        private void MainUser_Load(object sender, EventArgs e)
        {
            UserDashboard Ud = new UserDashboard();
            MainPanel.Controls.Add(Ud);
            Ud.Dock = DockStyle.Fill; ;
            Ud.Show();
        }
    }
}
