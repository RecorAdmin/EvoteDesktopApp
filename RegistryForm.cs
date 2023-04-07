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
            //initializing an instance of the database entity
            evotesEntity = new EvotesEntities2();
        }


        private void btnSighnUp_Click(object sender, EventArgs e)
        {
            try
            {
                //passing the text entered into the text box to variables
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


      ////////////validation to ensure content in the text box are validated///////////////
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
                    //creating an instance of registrRecord and Ulogin from the database
                    var registryRecord = new registryRecord();
                    var loginRecord = new Ulogin();

                    //passing variable with content to the database(s)object
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

                    //addint data entered to the actual database
                    evotesEntity.registryRecords.Add(registryRecord);
                    evotesEntity.Ulogins.Add(loginRecord);

                    //message box to show after a valid form completion
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
            //to pass content in database to the form upon load event being activated
            var Parish = evotesEntity.difParishes.ToList();
            ParishcomboBox.DisplayMember = "Parish";
            ParishcomboBox.ValueMember = "ID";
            ParishcomboBox.DataSource = Parish;

        }
    }
}
