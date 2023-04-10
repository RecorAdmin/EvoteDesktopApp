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
    public partial class RegistryForm : Form
    {
        private readonly EvotesEntities2 _db;
        private readonly LoginForm _login;

        public RegistryForm()
        {
            InitializeComponent();
        }

        public RegistryForm(LoginForm login)
        {
            InitializeComponent();
            _db = new EvotesEntities2();
            _login = login;
        }

        private void btnSighnUp_Click(object sender, EventArgs e)
        {
            try
            {

                //passing the text entered into the text box to variables
                string fname = tbFname.Text;
                string mInit = tbmInitial.Text;
                string lname = tbLname.Text;

                string gender = null;
                if(MaleradioButton.Checked) 
                {
                    gender = MaleradioButton.Text; 
                }else if(FemaleradioButton.Checked)
                {
                    gender = FemaleradioButton.Text;
                }else if (OtherradioButton.Checked)
                {
                    gender = OtherradioButton.Text;
                }
                var dob = DOBdateTimePicker.Value;
                var parish = ParishcomboBox.Text;
                string community = tbCommunity.Text;
                string po = tbMailBox.Text;
                string usern = tbusername.Text.Trim();
                string email = tbEmail.Text;
                string pass = tbRgPass.Text;
                string cPass = tbRgCPass.Text;


              


      ////////////validation to ensure content in the text box are validated///////////////
                var Valid = true;
                var errorMessage = "";

                if(string.IsNullOrWhiteSpace(cPass) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(email)
                    || string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname))
                {
                    Valid = false;
                    errorMessage += "Error! Please enter missing information!";
                }

                if (cPass != pass)
                {
                    Valid = false;
                    errorMessage += "Error! Password does not match!";
                }

                SHA256 sha = SHA256.Create();

                //convert the input string to a byte array and compute the hash.
                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));

                /*create a new string builder to collect the bytes and create a string*/
                StringBuilder stringBuilder = new StringBuilder();

                /*loop through each byte of the hashed data and format as a hexadecimal string */
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                var hashedpass = stringBuilder.ToString();

                if (Valid)
                {
                    //creating an instance of registrRecord and Ulogin from the database
                    var registryRecord = new registryRecord();
                    var loginRecord = new Ulogin();

                    //passing variable with content to the database(s)object
                    registryRecord.firstName = fname;
                    registryRecord.middleInitial = mInit;
                    registryRecord.lastName = lname;
                    registryRecord.gender = gender;
                    registryRecord.dateOfBirth = dob;
                    registryRecord.parishID = (int)ParishcomboBox.SelectedValue;
                    registryRecord.district = community;
                    registryRecord.poBox = po;
                    registryRecord.email = email;
                  
                    loginRecord.username = usern;
                    loginRecord.password = hashedpass;

                    

                    //message box to show after a valid form completion
                    MessageBox.Show($"--Registration Successful--\n\r" +
                        $"Name: {fname} {mInit}. {lname}\n\r" +
                        $"Gender: {gender}\n\r" +
                        $"Address: {community},\n{po},\n{parish}\n\r" +
                        $"Email: {email}\n\r" +
                        $"Username: {usern}");

                    //adding data entered to the actual database
                    _db.registryRecords.Add( registryRecord );
                    _db.Ulogins.Add( loginRecord );
                    _db.SaveChanges();

                    this.Hide();
                    _login.Show();


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
            var Parish = _db.difParishes.ToList();
            ParishcomboBox.DisplayMember = "Parish";
            ParishcomboBox.ValueMember = "ID";
            ParishcomboBox.DataSource = Parish;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _login.Show();
            
        }

        private void RegistryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
