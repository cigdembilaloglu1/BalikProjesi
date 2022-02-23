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
using BalikProjesi.Enums;


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
            
            this.MaximizeBox = false;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = txtUsername.Text.Trim();
            string Pass = txtPass.Text.Trim();
            User.ToLower();
            

            var result=lgn.CheckLogin(User, Pass);
            if (result == true)
            {
                var role = lgn.GetByName(User);
                if (role.Role==InputEnums.Admin)
                {
                    frmAdmin frAdmin = new frmAdmin();
                    frAdmin.Show();
                    this.Hide();
                }
                if (role.Role==InputEnums.User)
                {
                    frmUser frUser = new frmUser();
                    frUser.Show();
                    this.Hide();

                }
                
            }
            else
            {
                MessageBox.Show("Giriş bilgileri hatalıdır");
                txtUsername.Text = "";
                txtPass.Text ="";


            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
