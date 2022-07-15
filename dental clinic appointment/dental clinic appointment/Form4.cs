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
    public partial class myappointmentform : Form
    {
        public myappointmentform()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void myappointmentform_Load(object sender, EventArgs e)
        {

=======
        public String username;

        private void myappointmentform_Load(object sender, EventArgs e)
        {
            MessageBox.Show(username);
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "SELECT firstname, lastname, contact_number, date, time, services, approve, assign_room FROM appointment_table WHERE username = '"+ username +"'"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            appointGridView.DataSource = dt;
>>>>>>> 3a29c1d3557ec75c3f97733f78a8dd764a89f36b
        }
    }
}
