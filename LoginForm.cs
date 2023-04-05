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
        private readonly EvotesEntities2 evotesEntity;

        public LoginForm()
        {
            evotesEntity = new EvotesEntities2();
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
                    MainForm mainWindow = new MainForm();
                    mainWindow.ShowDialog();
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
        }
    }
}
