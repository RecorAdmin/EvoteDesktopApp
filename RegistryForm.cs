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
    public partial class RegistryForm : Form
    {
        private readonly EvotesEntities2 evotesEntity;
        public RegistryForm()
        {
            InitializeComponent();
            evotesEntity = new EvotesEntities2();
        }


        private void btnSighnUp_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = tbFname.Text;
                string mname = tbMname.Text;
                string lname = tbLname.Text;
                string gender = Genderlabel.Text;
                var dob = DOBdateTimePicker.Value;

                var parish = ParishcomboBox.Text;

                string community = tbCommunity.Text;
                string po = tbMailBox.Text;
                string email = tbEmail.Text;
                string pass = tbRgPass.Text;
                string cPass = tbRgCPass.Text;

                var Valid = true;
                var errorMessage = "";

                if(string.IsNullOrWhiteSpace(cPass) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(email)
                    || string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(gender))
                {
                    Valid = false;
                    errorMessage += "Error! Please enter missing information!";
                }

                if (cPass != pass)
                {
                    Valid = false;
                    errorMessage += "Error! Password does not match!";
                }



                if (Valid)
                {
                    var registryRecord = new registryRecord();
                    var loginRecord = new Ulogin();

                    registryRecord.firstName = fname;
                    registryRecord.middleName = mname;
                    registryRecord.lastName = lname;
                    registryRecord.gender = gender;
                    registryRecord.dateOfBirth = dob;
                    registryRecord.parishID = (int)ParishcomboBox.SelectedValue;
                    registryRecord.district = community;
                    registryRecord.poBox = po;

                    loginRecord.username = email;
                    loginRecord.password = pass;

                    evotesEntity.registryRecords.Add(registryRecord);
                    evotesEntity.Ulogins.Add(loginRecord);

                    MessageBox.Show($"Name: {fname} {mname} {lname}\n\r" +
                        $"Gender: {gender}\n\r" +
                        $"Address: {parish}, {community}, {po}\n\r" +
                        $"Email: {email}");
                }
                else
                {
                    MessageBox.Show(errorMessage); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

            var parishes = evotesEntity.difParishes.ToList();
            ParishcomboBox.DisplayMember = "Name";
            ParishcomboBox.ValueMember = "ID";
            ParishcomboBox.DataSource = parishes;

        }
    }
}
