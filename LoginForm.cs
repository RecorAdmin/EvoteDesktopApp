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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string username = tbUsername.Text;
                string loginPass = tbloginPassword.Text;

                var isValid = true;
                var errorCode = "";

                    if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(loginPass))
                    {
                        isValid = false;
                        errorCode += ("Please Enter Missing Data \n\r");

                    }

                    if (username != null && string.IsNullOrWhiteSpace(loginPass) || string.IsNullOrWhiteSpace(username) && loginPass != null)
                    {
                        isValid = false;
                        errorCode += ("Username or Password is incorrect \n\r");
                    }
                }catch  
                (Exception ex) { 

                    throw;
                 }
            }

        private void linkRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reglink = new RegisterForm();
            reglink.Show();
        }
    }
}
