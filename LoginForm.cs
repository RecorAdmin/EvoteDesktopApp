using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        private readonly EvotesEntities _db;

        public LoginForm()
        {
            _db = new EvotesEntities();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                

                string username = tbUsername.Text;
                string loginPass = tbloginPassword.Text;

                var valid = true;
                var errorCode = "";

                    if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(loginPass))
                    {
                        valid = false;
                        errorCode += ("Please Enter Missing Data \n\r");

                    }

                    if (username != null && string.IsNullOrWhiteSpace(loginPass) || string.IsNullOrWhiteSpace(username) && loginPass != null)
                    {
                        valid = false;
                        errorCode += ("Username or Password is incorrect \n\r");
                    }

                if (valid)
                {
                    
                    MainForm mainWindow = new MainForm(this);
                    mainWindow.Show();
                    this.Hide();
                }
                }catch  
                (Exception ex) { 

                MessageBox.Show(ex.Message);
                // throw;
            }
            }

        private void linkRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reglink = new RegistryForm();
            reglink.Show();
            this.Hide();

        }
    }
}
