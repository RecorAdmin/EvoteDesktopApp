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
    public partial class Candi_Management : Form
    {
        private readonly EvotesEntities2 _db;
        public Candi_Management()
        {
            InitializeComponent();
            _db = new EvotesEntities2();
        }
        
        private void Candi_Management_Load(object sender, EventArgs e)
        {
            var candidate_db = _db.CRegistries.Select(get => new {ID =get.ID, fname = get.firstName, MI = get.mInitial, 
                lname = get.lastName, Gender = get.gender, Parish = get.parishID, Community = get.community, 
                Activity = get.communityActivities}).ToList();
            gvCandidates.DataSource = candidate_db;
            //gvCandidates.Columns[0].HeaderText = "ID";
            gvCandidates.Columns[1].HeaderText = "First Name";
            gvCandidates.Columns[2].HeaderText = "Middle Initial";
            gvCandidates.Columns[3].HeaderText = "Last Name";
            //gvCandidates.Columns[4].HeaderText = "Gender";
            //gvCandidates.Columns[5].HeaderText = "Parish";
           // gvCandidates.Columns[6].HeaderText = "Community";
            //gvCandidates.Columns[7].HeaderText = "Activity";
        }

        private void btncEdit_Click(object sender, EventArgs e)
        {

        }

        private void btncDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
