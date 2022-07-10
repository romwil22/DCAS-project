﻿
namespace dental_clinic_appointment
{
    partial class frmdoktorregister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomCmbBx = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.passwordTxtBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.password2TxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTxtBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTxtBx = new System.Windows.Forms.TextBox();
            this.contactNumberTxtBx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ageTxtBx = new System.Windows.Forms.TextBox();
            this.lastnameTxtBx = new System.Windows.Forms.TextBox();
            this.firsnameTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roomCmbBx);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.birthdayPicker);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.passwordTxtBx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.password2TxtBx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.usernameTxtBx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addressTxtBx);
            this.groupBox1.Controls.Add(this.contactNumberTxtBx);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.femaleRadio);
            this.groupBox1.Controls.Add(this.maleRadio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ageTxtBx);
            this.groupBox1.Controls.Add(this.lastnameTxtBx);
            this.groupBox1.Controls.Add(this.firsnameTxtBx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 367);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // roomCmbBx
            // 
            this.roomCmbBx.FormattingEnabled = true;
            this.roomCmbBx.Items.AddRange(new object[] {
            "Rm 1",
            "Rm 2"});
            this.roomCmbBx.Location = new System.Drawing.Point(332, 199);
            this.roomCmbBx.Name = "roomCmbBx";
            this.roomCmbBx.Size = new System.Drawing.Size(121, 21);
            this.roomCmbBx.TabIndex = 24;
            this.roomCmbBx.SelectedIndexChanged += new System.EventHandler(this.roomCmbBx_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Select Room:";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.birthdayPicker.Location = new System.Drawing.Point(103, 182);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(194, 20);
            this.birthdayPicker.TabIndex = 21;
            this.birthdayPicker.Value = new System.DateTime(2022, 7, 7, 0, 0, 0, 0);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(234, 324);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(111, 37);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(351, 311);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(140, 50);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(364, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // passwordTxtBx
            // 
            this.passwordTxtBx.Location = new System.Drawing.Point(119, 56);
            this.passwordTxtBx.Name = "passwordTxtBx";
            this.passwordTxtBx.Size = new System.Drawing.Size(239, 20);
            this.passwordTxtBx.TabIndex = 15;
            this.passwordTxtBx.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Confirm Password:";
            // 
            // password2TxtBx
            // 
            this.password2TxtBx.Location = new System.Drawing.Point(119, 89);
            this.password2TxtBx.Name = "password2TxtBx";
            this.password2TxtBx.Size = new System.Drawing.Size(239, 20);
            this.password2TxtBx.TabIndex = 13;
            this.password2TxtBx.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password:";
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Location = new System.Drawing.Point(119, 30);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(239, 20);
            this.usernameTxtBx.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username:";
            // 
            // addressTxtBx
            // 
            this.addressTxtBx.Location = new System.Drawing.Point(77, 244);
            this.addressTxtBx.Name = "addressTxtBx";
            this.addressTxtBx.Size = new System.Drawing.Size(239, 20);
            this.addressTxtBx.TabIndex = 9;
            // 
            // contactNumberTxtBx
            // 
            this.contactNumberTxtBx.Location = new System.Drawing.Point(119, 216);
            this.contactNumberTxtBx.Name = "contactNumberTxtBx";
            this.contactNumberTxtBx.Size = new System.Drawing.Size(152, 20);
            this.contactNumberTxtBx.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact Number:";
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(159, 152);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(59, 17);
            this.femaleRadio.TabIndex = 6;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            this.femaleRadio.CheckedChanged += new System.EventHandler(this.femaleRadio_CheckedChanged);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Location = new System.Drawing.Point(105, 152);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(48, 17);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gender:";
            // 
            // ageTxtBx
            // 
            this.ageTxtBx.Location = new System.Drawing.Point(253, 152);
            this.ageTxtBx.Name = "ageTxtBx";
            this.ageTxtBx.Size = new System.Drawing.Size(30, 20);
            this.ageTxtBx.TabIndex = 3;
            this.ageTxtBx.Text = "29";
            this.ageTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastnameTxtBx
            // 
            this.lastnameTxtBx.Location = new System.Drawing.Point(279, 119);
            this.lastnameTxtBx.Name = "lastnameTxtBx";
            this.lastnameTxtBx.Size = new System.Drawing.Size(84, 20);
            this.lastnameTxtBx.TabIndex = 3;
            // 
            // firsnameTxtBx
            // 
            this.firsnameTxtBx.Location = new System.Drawing.Point(119, 119);
            this.firsnameTxtBx.Name = "firsnameTxtBx";
            this.firsnameTxtBx.Size = new System.Drawing.Size(84, 20);
            this.firsnameTxtBx.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Birthday:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Lastname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firstname:";
            // 
            // frmdoktorregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmdoktorregister";
            this.Text = "doctor registration";
            this.Load += new System.EventHandler(this.frmdoktorregister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox passwordTxtBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password2TxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTxtBx;
        private System.Windows.Forms.TextBox contactNumberTxtBx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageTxtBx;
        private System.Windows.Forms.TextBox lastnameTxtBx;
        private System.Windows.Forms.TextBox firsnameTxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomCmbBx;
        private System.Windows.Forms.Label label11;
    }
}