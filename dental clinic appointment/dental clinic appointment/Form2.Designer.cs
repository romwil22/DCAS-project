namespace dental_clinic_appointment
{
    partial class frmappointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmappointment));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.othersCheckBox = new System.Windows.Forms.CheckBox();
            this.checkUpCheckBox = new System.Windows.Forms.CheckBox();
            this.cleaningCheckBox = new System.Windows.Forms.CheckBox();
            this.pastaCheckBox = new System.Windows.Forms.CheckBox();
            this.bunotCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomCommboBox = new System.Windows.Forms.ComboBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateSchedulePicker = new System.Windows.Forms.DateTimePicker();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.viewAppointmentBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Your Schedule";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.othersCheckBox);
            this.panel1.Controls.Add(this.checkUpCheckBox);
            this.panel1.Controls.Add(this.cleaningCheckBox);
            this.panel1.Controls.Add(this.pastaCheckBox);
            this.panel1.Controls.Add(this.bunotCheckBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.roomCommboBox);
            this.panel1.Controls.Add(this.timeComboBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateSchedulePicker);
            this.panel1.Location = new System.Drawing.Point(31, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 251);
            this.panel1.TabIndex = 2;
            // 
            // othersCheckBox
            // 
            this.othersCheckBox.AutoSize = true;
            this.othersCheckBox.Location = new System.Drawing.Point(140, 149);
            this.othersCheckBox.Name = "othersCheckBox";
            this.othersCheckBox.Size = new System.Drawing.Size(73, 22);
            this.othersCheckBox.TabIndex = 9;
            this.othersCheckBox.Text = "Others";
            this.othersCheckBox.UseVisualStyleBackColor = true;
            this.othersCheckBox.CheckedChanged += new System.EventHandler(this.othersCheckBox_CheckedChanged);
            // 
            // checkUpCheckBox
            // 
            this.checkUpCheckBox.AutoSize = true;
            this.checkUpCheckBox.Location = new System.Drawing.Point(235, 93);
            this.checkUpCheckBox.Name = "checkUpCheckBox";
            this.checkUpCheckBox.Size = new System.Drawing.Size(94, 22);
            this.checkUpCheckBox.TabIndex = 8;
            this.checkUpCheckBox.Text = "Check-up";
            this.checkUpCheckBox.UseVisualStyleBackColor = true;
            this.checkUpCheckBox.CheckedChanged += new System.EventHandler(this.checkUpCheckBox_CheckedChanged);
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.AutoSize = true;
            this.cleaningCheckBox.Location = new System.Drawing.Point(140, 121);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(89, 22);
            this.cleaningCheckBox.TabIndex = 8;
            this.cleaningCheckBox.Text = "Cleaning";
            this.cleaningCheckBox.UseVisualStyleBackColor = true;
            this.cleaningCheckBox.CheckedChanged += new System.EventHandler(this.cleaningCheckBox_CheckedChanged);
            // 
            // pastaCheckBox
            // 
            this.pastaCheckBox.AutoSize = true;
            this.pastaCheckBox.Location = new System.Drawing.Point(140, 93);
            this.pastaCheckBox.Name = "pastaCheckBox";
            this.pastaCheckBox.Size = new System.Drawing.Size(68, 22);
            this.pastaCheckBox.TabIndex = 7;
            this.pastaCheckBox.Text = "Pasta";
            this.pastaCheckBox.UseVisualStyleBackColor = true;
            this.pastaCheckBox.CheckedChanged += new System.EventHandler(this.pastaCheckBox_CheckedChanged);
            // 
            // bunotCheckBox
            // 
            this.bunotCheckBox.AutoSize = true;
            this.bunotCheckBox.Location = new System.Drawing.Point(235, 121);
            this.bunotCheckBox.Name = "bunotCheckBox";
            this.bunotCheckBox.Size = new System.Drawing.Size(137, 22);
            this.bunotCheckBox.TabIndex = 6;
            this.bunotCheckBox.Text = "Tooth Extraction";
            this.bunotCheckBox.UseVisualStyleBackColor = true;
            this.bunotCheckBox.CheckedChanged += new System.EventHandler(this.bunotCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Services:";
            // 
            // roomCommboBox
            // 
            this.roomCommboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.roomCommboBox.FormattingEnabled = true;
            this.roomCommboBox.Items.AddRange(new object[] {
            "Room 1",
            "Room 2"});
            this.roomCommboBox.Location = new System.Drawing.Point(73, 194);
            this.roomCommboBox.Name = "roomCommboBox";
            this.roomCommboBox.Size = new System.Drawing.Size(131, 26);
            this.roomCommboBox.TabIndex = 4;
            this.roomCommboBox.Text = "Select Room";
            // 
            // timeComboBox
            // 
            this.timeComboBox.BackColor = System.Drawing.Color.Silver;
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "8:00 - 9:00 (AM)",
            "9:00 - 10:00 (AM)",
            "10:00 - 11:00 (AM)",
            "11:00am - 12:00NN ",
            "1:00 - 2:00 (PM)",
            "2:00 - 3:00 (PM)",
            "3:00 - 4:00 (PM)",
            "4:00 - 5:00 (PM)"});
            this.timeComboBox.Location = new System.Drawing.Point(113, 46);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(166, 26);
            this.timeComboBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Room:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Date:";
            // 
            // dateSchedulePicker
            // 
            this.dateSchedulePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSchedulePicker.Location = new System.Drawing.Point(113, 11);
            this.dateSchedulePicker.Name = "dateSchedulePicker";
            this.dateSchedulePicker.Size = new System.Drawing.Size(125, 26);
            this.dateSchedulePicker.TabIndex = 0;
            this.dateSchedulePicker.Value = new System.DateTime(2022, 7, 7, 0, 0, 0, 0);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubmit.Location = new System.Drawing.Point(482, 152);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(249, 50);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit Appointment";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // viewAppointmentBtn
            // 
            this.viewAppointmentBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.viewAppointmentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAppointmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAppointmentBtn.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewAppointmentBtn.Location = new System.Drawing.Point(482, 254);
            this.viewAppointmentBtn.Name = "viewAppointmentBtn";
            this.viewAppointmentBtn.Size = new System.Drawing.Size(249, 50);
            this.viewAppointmentBtn.TabIndex = 6;
            this.viewAppointmentBtn.Text = "view my appointments";
            this.viewAppointmentBtn.UseVisualStyleBackColor = false;
            this.viewAppointmentBtn.Click += new System.EventHandler(this.viewAppointmentBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(482, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "logout";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(1, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hi,";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.usernameLabel.Location = new System.Drawing.Point(63, 97);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(176, 39);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "username";
            // 
            // frmappointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::dental_clinic_appointment.Properties.Resources.dental1;
            this.ClientSize = new System.Drawing.Size(788, 467);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.viewAppointmentBtn);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmappointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Schedule";
            this.Load += new System.EventHandler(this.frmappointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateSchedulePicker;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.CheckBox othersCheckBox;
        private System.Windows.Forms.CheckBox cleaningCheckBox;
        private System.Windows.Forms.CheckBox pastaCheckBox;
        private System.Windows.Forms.CheckBox bunotCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button viewAppointmentBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox roomCommboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkUpCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label usernameLabel;
    }
}