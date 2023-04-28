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

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var can_registry = new CandidateRegistry();
            can_registry.MdiParent = this;
            can_registry.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var candi_list = new Candi_Management();
            candi_list.MdiParent = this;
            candi_list.Show();
        }
    }
}
