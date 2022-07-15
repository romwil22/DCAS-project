using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dental_clinic_appointment
{
    public partial class frmLogin : Form
    {
        
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtpassword.Text = "";
            txtpassword.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form2 = new frmappointment();
            var form5 = new doctorProfile();

            if (accountType == "doctor")
            {
                // doctor user validation
                String connection = "server=localhost;user id=root;pssword=;database=dcas_db";
                MySqlConnection conn = new MySqlConnection(connection);
                String doctorDB = "SELECT * FROM doctor_registration_table WHERE username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
                MySqlDataReader drDoctor;
                MySqlCommand cmdDoctor = new MySqlCommand(doctorDB, conn);

                conn.Open();

                drDoctor = cmdDoctor.ExecuteReader();
                drDoctor.Read();

                if (drDoctor.HasRows)
                {
                    // log datetime
                    String logDateTime = "VALUES('" + txtusername.Text + "', '" + DateTime.Now.ToString() + "')";
                    usernameLogMonitor(logDateTime);
                    form5.firstname = drDoctor["firstname"].ToString();
                    form5.lastname = drDoctor["lastname"].ToString();
                    form5.username = drDoctor["username"].ToString();
                    form5.assignRoom = drDoctor["assign_room"].ToString();
                    form5.Show();
                }
                else
                {
                    MessageBox.Show("Inavalid username or password");
                }

                conn.Close();

            }
            else if (accountType == "patient")
            {
                // patient user validation
                String connection = "server=localhost;user id=root;pssword=;database=dcas_db";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlDataReader drPatient;
                String patientDB = "SELECT * FROM patient_registration_table WHERE username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
                MySqlCommand cmdPatient = new MySqlCommand(patientDB, conn);

                conn.Open();

                drPatient = cmdPatient.ExecuteReader();
                drPatient.Read();

                if (drPatient.HasRows)
                {
                    // log datetime
                    String logDateTime = "VALUES('" + txtusername.Text + "', '" + DateTime.Now.ToString() + "')";
                    usernameLogMonitor(logDateTime);
                    Form2.patientID = drPatient["patient_id"].ToString();
                    Form2.Show();
                }
                else
                {
                    MessageBox.Show("Inavalid username or password");
                }

                conn.Close();

            }
            else
            {
                MessageBox.Show("Please select account type.");
            }
            

            



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form3 = new frmpatientregister();
            form3.Show();
            
        }

        private void usernameLogMonitor(String usernameLog)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "INSERT INTO login_table (username,log_datetime) " + usernameLog; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataReader dr; // data reader

            conn.Open(); // open db

            dr = cmd.ExecuteReader();

            conn.Close(); // close db

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string accountType;
        private void doctorRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            accountType = "doctor";
        }

        private void patientRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            accountType = "patient";
        }
    }
}
