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
    public partial class frmappointment : Form
    {
        public string patientID;
        string firstname, lastname, contactNumber;
        public frmappointment()
        {
            InitializeComponent();
        }

        private void frmappointment_Load(object sender, EventArgs e)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "SELECT * FROM patient_registration_table WHERE patient_id = '" + patientID + "'";//sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataReader drPatientProfile; // data reader

            conn.Open(); // open db

            drPatientProfile = cmd.ExecuteReader();
            drPatientProfile.Read();

            if (drPatientProfile.HasRows)
            {
                usernameLabel.Text = drPatientProfile["username"].ToString();
                firstname = drPatientProfile["firstname"].ToString();
                lastname = drPatientProfile["lastname"].ToString();
                contactNumber = drPatientProfile["contact_number"].ToString();
            }

            conn.Close(); // close db
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "INSERT INTO appointment_table (username,firstname,lastname,contact_number,date,time,services,assign_room) VALUES('"+ usernameLabel.Text +"', '"+ firstname +"', '"+ lastname +"', '"+ contactNumber +"', '"+ dateSchedulePicker.Text +"', '"+ timeComboBox.SelectedItem +"', '"+ service +"', '"+ roomCommboBox.SelectedItem +"')"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataReader dr; // data reader

            conn.Open(); // open db

            dr = cmd.ExecuteReader();

            conn.Close(); // close db

            MessageBox.Show("Your appointment summit, wait for approval.");
            service = null;
        }
        string service;

        private void bunotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (service == null)
            {
                service = "Bunot";
            }
            else
            {
                service += ", " + "Bunot";
            }
        }

        private void pastaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (service == null)
            {
                service = "Pasta";
            }
            else
            {
                service += ", " + "Pasta";
            }
        }

        private void cleaningCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (service == null)
            {
                service = "Cleaning";
            }
            else
            {
                service += ", " + "Cleaning";
            }
        }

        private void viewAppointmentBtn_Click(object sender, EventArgs e)
        {
            var form4 = new myappointmentform();
            form4.username = usernameLabel.Text;
            form4.Show();
        }

        private void checkUpCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (service == null)
            {
                service = "Check-up";
            }
            else
            {
                service += ", " + "Check-up";
            }
        }

        private void othersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (service == null)
            {
                service = "Others";
            }
            else
            {
                service += ", " + "Others";
            }

            
        }
    }
}
