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
    public partial class CandidateRegistry : Form
    {
        private readonly EvotesEntities2 _db;
        public CandidateRegistry()
        {
            InitializeComponent();
            _db = new EvotesEntities2();
        }


        private void btnCsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //passing textbox content to variables
                String cFname = tbCfName.Text.Trim();
                String cInitial = tbCmInitial.Text.Trim();
                String cLname = tbClName.Text.Trim();
                String cGender = null;

                if (rbMale.Checked)
                {
                    cGender = rbMale.Text;
                }
                else if (rbfMale.Checked)
                {
                    cGender = rbfMale.Text;
                }
                else if (rbOther.Checked)
                {
                    cGender = rbOther.Text;
                }

                var cParish = cbParishes.Text;
                String cCom = tbCommunity.Text; ;
                String cActivity =  tbDiaPromises.Text;;


                //////////Validation///////////
                var valid = true;
                var errorcode = "";

                if (string.IsNullOrWhiteSpace(cFname) || string.IsNullOrWhiteSpace(cLname) || string.IsNullOrWhiteSpace(cGender)
                    || string.IsNullOrWhiteSpace(cParish))
                {
                    valid = false;
                    errorcode += "Error! Please enter missing information!";
                }



                if (valid)
                {
                    var candi_Registry = new CRegistry();

                    candi_Registry.firstName = cFname;
                    candi_Registry.mInitial = cInitial;
                    candi_Registry.lastName = cLname;
                    candi_Registry.gender = cGender;
                    candi_Registry.parishID = (int)cbParishes.SelectedValue;
                    candi_Registry.community = cCom;
                    candi_Registry.communityActivities = cActivity;


                    MessageBox.Show($"--Registration Successful--\n\r" +
                        $"Name: {cFname} {cInitial}. {cLname}\n\r" +
                        $"Gender: {cGender}\n\r" +
                        $"Constituency: {cCom}, {cParish}\n\r" +
                        $"Contribution & Promises: {cActivity}");

                    _db.CRegistries.Add(candi_Registry);
                    _db.SaveChanges();

                    this.Close();
                }
                else
                {
                    MessageBox.Show(errorcode);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void CandidateRegistry_Load(object sender, EventArgs e)
        {
            //selecting * from difParishes//
            var Parish = _db.difParishes.ToList();

            cbParishes.DisplayMember = "Parish";
            cbParishes.ValueMember = "ID";
            cbParishes.DataSource = Parish;
        }
    }
}
