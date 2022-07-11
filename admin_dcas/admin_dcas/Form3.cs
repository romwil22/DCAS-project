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
    public partial class doctorRegistration : Form
    {
        public doctorRegistration()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            // doctor registration
            String queryDoctorInfo = "VALUES ('"+ usernameTxBx.Text +"', '"+ passwordTxBx.Text +"', '"+ firstnameTxBx.Text +"', '"+ lastnameTxBx.Text +"', '"+ emailTxBx.Text +"', '"+ contactNumberTxBx.Text +"', '"+ addressTxBx.Text +"', '"+ gender +"', '"+ birthdatePicker.Text +"', '"+ roomCmbBx.SelectedItem +"')";
            registerDoctorInfo(queryDoctorInfo);

            // account registration
            String queryDoctorAccount = "VALUES ('" + usernameTxBx.Text + "', '" + firstnameTxBx.Text + "', '" + lastnameTxBx.Text + "', '" + emailTxBx.Text + "', '" + contactNumberTxBx.Text + "', 'doctor')";
            doctorAccount(queryDoctorAccount);
        }

        // DCAS function
        private void registerDoctorInfo(String doctorInfo)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "INSERT INTO doctor_registration_table (username,password,firstname,lastname,email,contact_number,address,gender,birthdate,assign_room) " + doctorInfo; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataReader dr; // data reader

            conn.Open(); // open db

            dr = cmd.ExecuteReader();

            MessageBox.Show("doctor account register");

            conn.Close(); // close db
        }

        private void doctorAccount(String accountInfo)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "INSERT INTO account_table (username,firstname,lastname,email,contact_number,user_type) " + accountInfo; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataReader dr; // data reader

            conn.Open(); // open db

            dr = cmd.ExecuteReader();

            MessageBox.Show("account register");

            conn.Close(); // close db
        }



        String gender;
        private void maleRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void femaleRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
