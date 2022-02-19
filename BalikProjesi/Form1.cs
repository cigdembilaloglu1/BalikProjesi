using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalikProjesi.Services;


namespace BalikProjesi
{
    public partial class Form1 : Form
    {
        ILoginServices lgn;
        public Form1()
        {
            InitializeComponent();
            lgn = new LoginServices();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Kullanıcı adı";
            label2.Text = "Parola";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = txtUsername.Text.Trim();
            string Pass = txtPass.Text.Trim();

            var result=lgn.CheckLogin(User, Pass);
            if (result == true)
            {
                var role = lgn.GetByName(User);
                if (role.Role=="Admin")
                {
                    frmAdmin frAdmin = new frmAdmin();
                    frAdmin.Show();
                    this.Hide();
                }
                if (role.Role=="User")
                {
                    frmUser frUser = new frmUser();
                    frUser.Show();
                    this.Hide();

                }
                
            }
            else
            {
                MessageBox.Show("Giriş bilgileri hatalıdır");
            }
        }
    }
}
