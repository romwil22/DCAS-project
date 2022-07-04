using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.Hide();
            Form2.Show();

        }
    }
}
