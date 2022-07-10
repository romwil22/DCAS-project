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
    public partial class frmdoktorregister : Form
    {
        // DCAS function

        private void doctorRegistration(String doctorData)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "INSERT INTO doctor_registration_table (username,password,user_id,last_name,first_name,address,birthdate,assign_room,contact_number,gender) " + doctorData; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataReader dr; // data reader

            conn.Open(); // open db

            dr = cmd.ExecuteReader();

            MessageBox.Show("doctor account register");

            conn.Close(); // close db
        }

        public frmdoktorregister()
        {
            InitializeComponent();
        }

        private void frmdoktorregister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String queryValue = "VALUES('" + usernameTxtBx.Text + "', '" + passwordTxtBx.Text + "', 1, '" + lastnameTxtBx.Text + "', '" + firsnameTxtBx.Text + "', '" + addressTxtBx.Text + "', '" + birthdayPicker.Value.Date.ToString() + "', '" + roomCmbBx.SelectedItem + "', '" + contactNumberTxtBx.Text + "', '" + gender + "')";
            doctorRegistration(queryValue);

            var form4 = new frmdoktorregister();
            form4.Close();

            var form1 = new frmLogin();
            form1.Show();
        }


        private void roomCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        String gender;
        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }
    }
}
