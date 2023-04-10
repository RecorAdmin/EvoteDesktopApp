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
        private readonly EvotesEntities2 _db;

        public LoginForm()
        {
            InitializeComponent();
            _db = new EvotesEntities2();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                

                string username = tbUsername.Text.Trim();
                string loginPass = tbloginPassword.Text;

                var user = _db.Ulogins.FirstOrDefault(u => u.username==username && u.password == loginPass);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }else
                {
                    MainForm mainWindow = new MainForm(this);
                    mainWindow.Show();
                    this.Hide();
                }

                }catch  
                (Exception ex) { 

                    MessageBox.Show(ex.Message);
                }
            }

        private void linkRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reglink = new RegistryForm(this);
            reglink.Show();
            this.Hide();
        }
    }
}
