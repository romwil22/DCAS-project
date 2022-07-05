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
            //var Form2 = new frmappointment();
            // this.Hide();
            // Form2.Show();
            usernameLogMonitor(txtusername.Text);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form3 = new frmpatientregister();
            form3.Show();
            this.Hide();
        }

        private void usernameLogMonitor(String usernameLog)
        {
            String connection = "server=localhost;user id=root;pssword=;database=dcas_db"; //connection
            String query = "INSERT INTO login_table (username) VALUES('" + usernameLog + "')"; //sql statement

            MySqlConnection conn = new MySqlConnection(connection); // connection to database
            MySqlCommand cmd = new MySqlCommand(query, conn); // qury command
            MySqlDataReader dr; // data reader

            conn.Open(); // open db

            dr = cmd.ExecuteReader();

            MessageBox.Show("username log record successfully.");

            conn.Close(); // close db

        }
    }
}
