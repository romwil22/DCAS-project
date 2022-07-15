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
            MySqlDataReader dr; // data reader

            conn.Open(); // open db

            dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                //username
            }

            conn.Close(); // close db
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
