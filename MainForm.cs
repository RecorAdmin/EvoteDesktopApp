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
    public partial class MainForm : Form
    {
        private LoginForm _login;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(LoginForm login)
        {
            InitializeComponent();
            _login = login;
        }

        private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
