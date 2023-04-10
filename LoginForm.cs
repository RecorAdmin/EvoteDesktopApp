using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
                SHA256 sha = SHA256.Create();

                string username = tbUsername.Text.Trim();
                string loginPass = tbloginPassword.Text;

                //convert the input string to a byte array and compute the hash.
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(loginPass));

                /*create a new string builder to collect the bytes and create a string*/
                StringBuilder stringBuilder= new StringBuilder();

                /*loop through each byte of the hashed data and format as a hexadecimal string */
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                var hashedpass = stringBuilder.ToString();

                var user = _db.Ulogins.FirstOrDefault(u => u.username==username && u.password == hashedpass);

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
