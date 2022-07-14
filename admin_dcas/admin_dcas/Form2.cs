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

namespace admin_dcas
{
    public partial class adminProfile : Form
    {
        public adminProfile()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form3 = new doctorRegistration();
            var form2 = new adminProfile();

            form3.Show();
            form2.Hide();
        }

        private void adminProfile_Load(object sender, EventArgs e)
        {
            recordLabel.Text = "Account";
            accountRecord();
        }

        private void accountRecord()
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "SELECT * FROM account_table"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            recordGridView.DataSource = dt;
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            recordLabel.Text = "Accounts Record";
            accountRecord();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            recordLabel.Text = "Login Record";

            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "SELECT * FROM login_table"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            recordGridView.DataSource = dt;
            
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            recordLabel.Text = "Doctors Record";

            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "SELECT * FROM doctor_registration_table"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            recordGridView.DataSource = dt;
        }

        private void patientBtn_Click(object sender, EventArgs e)
        {
            recordLabel.Text = "Patients Record";
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "SELECT * FROM patient_registration_table"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            recordGridView.DataSource = dt;
        }

        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            recordLabel.Text = "Appointment Record";
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "SELECT * FROM appointment_table"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            recordGridView.DataSource = dt;
        }
    }
}
