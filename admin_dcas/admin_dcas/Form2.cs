﻿using System;
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
    public partial class adminProfile : Form
    {
        public adminProfile()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form3 = new doctorRegistration();
            var form2 = new adminProfile();

            form3.Show();
            form2.Hide();
        }
    }
}
