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
    
    public partial class doctorProfile : Form
    {
        public String firstname, lastname, username, assignRoom;
        public doctorProfile()
        {
            InitializeComponent();
        }

        private void doctorProfile_Load(object sender, EventArgs e)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "SELECT * FROM appointment_table WHERE assign_room = '"+ assignRoom +"'"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            appointGridView.DataSource = dt;

            fullnameLabel.Text = firstname + " " + lastname;
            usernameLabel.Text = username;
            roomLabel.Text = assignRoom;
        }

        
    }
}
