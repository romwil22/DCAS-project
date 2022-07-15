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

            // patient user validation
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;pssword=;database=dcas_db");
            MySqlDataAdapter daPatientUser;
            DataTable patientUserTable = new DataTable();
            MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM patient_registration_table WHERE username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'", conn);

            conn.Open();

            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                // log datetime
                String logDateTime = "VALUES('" + txtusername.Text + "', '" + DateTime.Now.ToString() + "')";
                usernameLogMonitor(logDateTime);
                Form2.patientID = dr["patient_id"].ToString();
                Form2.Show();
            }

            conn.Close();


            

            //daPatientUser = new MySqlDataAdapter("SELECT * FROM patient_registration_table WHERE username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'", conn);
            //daPatientUser.Fill(patientUserTable);

            // doctor user validation
            MySqlDataAdapter daDoctorUser;
            DataTable doctorUserTable = new DataTable();

            daDoctorUser = new MySqlDataAdapter("SELECT * FROM doctor_registration_table WHERE username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'", conn);
            daDoctorUser.Fill(doctorUserTable);

            //var Form2 = new frmappointment();
            //var form5 = new doctorProfile();

            //if (patientUserTable.Rows.Count > 0) // patient log
            //{

            //    // log datetime
            //    String logDateTime = "VALUES('" + txtusername.Text + "', '" + DateTime.Now.ToString() + "')";
            //    usernameLogMonitor(logDateTime);

            //    Form2.Show();
            //}
            //else if (doctorUserTable.Rows.Count > 0)
            //{
            //    // log datetime
            //    String logDateTime = "VALUES('" + txtusername.Text + "', '" + DateTime.Now.ToString() + "')";
            //    usernameLogMonitor(logDateTime);
            //    form5.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Inavalid username or password");
            //}



            //var form5 = new doctorProfile();
            //form5.Show();



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
    }
}
