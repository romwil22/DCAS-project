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
            Form2.Show();

            var form5 = new doctorProfile();
            form5.Show();

            // log datetime
            String logDateTime = "VALUES('" + txtusername.Text + "', '" + DateTime.Now.ToString() + "')";
            usernameLogMonitor(logDateTime);

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
            var form4 = new frmdoktorregister();
                form4.Show();
                
        }
    }
}
