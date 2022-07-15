﻿using System;
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
    public partial class frmpatientregister : Form
    {
        public frmpatientregister()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passwordTxtBx.UseSystemPasswordChar = false;
                password2TxtBx.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTxtBx.UseSystemPasswordChar = true;
                password2TxtBx.UseSystemPasswordChar = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var form1 = new frmLogin();
            form1.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // patient registration
            String querypatientInfo;
            querypatientInfo = "VALUES('" + usernameTxtBx.Text + "', '" + passwordTxtBx.Text + "', '"+firstnameTxtBx.Text +"', '"+ lastnameTxtBx.Text +"', '"+ emailTxtBx.Text +"', '"+ contactNumberTxtBx.Text +"', '"+ addressTxtBx.Text +"', '"+ birthdayPicker.Text +"', '"+ gender +"', '"+ ageTxtBx.Text +"')";
            patientRegistration(querypatientInfo);

            // patient account registration
            String queryPatientAccount = "VALUES ('" + usernameTxtBx.Text + "', '" + firstnameTxtBx.Text + "', '" + lastnameTxtBx.Text + "', '" + emailTxtBx.Text + "', '" + contactNumberTxtBx.Text + "', 'doctor')";
            patientAccount(queryPatientAccount);

        }

        //DCAS function

        private void patientRegistration(String patientData)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "INSERT INTO patient_registration_table (username,password,firstname,lastname,email,contact_number,address,birthdate,gender,age) " + patientData; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataReader dr; // data reader

            conn.Open(); // open db

            dr = cmd.ExecuteReader();

            MessageBox.Show("account register");

            conn.Close(); // close db
        }

        private void patientAccount(String accountInfo)
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
        private void maleRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void frmpatientregister_Load(object sender, EventArgs e)
        {

        }
    }
}
