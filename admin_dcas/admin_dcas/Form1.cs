using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_dcas
{
    public partial class adminLog : Form
    {
        public adminLog()
        {
            InitializeComponent();
        }

        const String admin = "admin";
        const String password = "1234";
        private void logButton_Click(object sender, EventArgs e)
        {
            if (adminTxBx.Text == admin  && passwordTxBx.Text == password)
            {
                var form2 = new adminProfile();
                form2.Show();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void adminLog_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void adminLog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logButton.PerformClick();
            }
        }

        private void adminLog_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void adminLog_Load(object sender, EventArgs e)
        {
            
        }

        private void adminTxBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logButton.PerformClick();
            }
        }

        private void passwordTxBx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logButton.PerformClick();
            }
        }
    }
}
