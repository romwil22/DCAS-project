
namespace admin_dcas
{
    partial class doctorRegistration
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.maleRadBtn = new System.Windows.Forms.RadioButton();
            this.femaleRadBtn = new System.Windows.Forms.RadioButton();
            this.roomCmbBx = new System.Windows.Forms.ComboBox();
            this.lastnameTxBx = new System.Windows.Forms.TextBox();
            this.addressTxBx = new System.Windows.Forms.TextBox();
            this.firstnameTxBx = new System.Windows.Forms.TextBox();
            this.contactNumberTxBx = new System.Windows.Forms.TextBox();
            this.emailTxBx = new System.Windows.Forms.TextBox();
            this.password2TxBx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTxBx = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.usernameTxBx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerBtn);
            this.groupBox1.Controls.Add(this.birthdatePicker);
            this.groupBox1.Controls.Add(this.maleRadBtn);
            this.groupBox1.Controls.Add(this.femaleRadBtn);
            this.groupBox1.Controls.Add(this.roomCmbBx);
            this.groupBox1.Controls.Add(this.lastnameTxBx);
            this.groupBox1.Controls.Add(this.addressTxBx);
            this.groupBox1.Controls.Add(this.firstnameTxBx);
            this.groupBox1.Controls.Add(this.contactNumberTxBx);
            this.groupBox1.Controls.Add(this.emailTxBx);
            this.groupBox1.Controls.Add(this.password2TxBx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.passwordTxBx);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.usernameTxBx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(351, 302);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(140, 50);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatePicker.Location = new System.Drawing.Point(110, 203);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(97, 20);
            this.birthdatePicker.TabIndex = 4;
            // 
            // maleRadBtn
            // 
            this.maleRadBtn.AutoSize = true;
            this.maleRadBtn.Location = new System.Drawing.Point(110, 175);
            this.maleRadBtn.Name = "maleRadBtn";
            this.maleRadBtn.Size = new System.Drawing.Size(47, 17);
            this.maleRadBtn.TabIndex = 3;
            this.maleRadBtn.TabStop = true;
            this.maleRadBtn.Text = "male";
            this.maleRadBtn.UseVisualStyleBackColor = true;
            this.maleRadBtn.CheckedChanged += new System.EventHandler(this.maleRadBtn_CheckedChanged);
            // 
            // femaleRadBtn
            // 
            this.femaleRadBtn.AutoSize = true;
            this.femaleRadBtn.Location = new System.Drawing.Point(163, 175);
            this.femaleRadBtn.Name = "femaleRadBtn";
            this.femaleRadBtn.Size = new System.Drawing.Size(56, 17);
            this.femaleRadBtn.TabIndex = 3;
            this.femaleRadBtn.TabStop = true;
            this.femaleRadBtn.Text = "female";
            this.femaleRadBtn.UseVisualStyleBackColor = true;
            this.femaleRadBtn.CheckedChanged += new System.EventHandler(this.femaleRadBtn_CheckedChanged);
            // 
            // roomCmbBx
            // 
            this.roomCmbBx.FormattingEnabled = true;
            this.roomCmbBx.Items.AddRange(new object[] {
            "Room 1",
            "Room 2"});
            this.roomCmbBx.Location = new System.Drawing.Point(277, 30);
            this.roomCmbBx.Name = "roomCmbBx";
            this.roomCmbBx.Size = new System.Drawing.Size(121, 21);
            this.roomCmbBx.TabIndex = 2;
            
            // 
            // lastnameTxBx
            // 
            this.lastnameTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTxBx.Location = new System.Drawing.Point(318, 140);
            this.lastnameTxBx.Name = "lastnameTxBx";
            this.lastnameTxBx.Size = new System.Drawing.Size(112, 20);
            this.lastnameTxBx.TabIndex = 0;
            // 
            // addressTxBx
            // 
            this.addressTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxBx.Location = new System.Drawing.Point(110, 238);
            this.addressTxBx.Name = "addressTxBx";
            this.addressTxBx.Size = new System.Drawing.Size(323, 20);
            this.addressTxBx.TabIndex = 0;
            // 
            // firstnameTxBx
            // 
            this.firstnameTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTxBx.Location = new System.Drawing.Point(110, 140);
            this.firstnameTxBx.Name = "firstnameTxBx";
            this.firstnameTxBx.Size = new System.Drawing.Size(112, 20);
            this.firstnameTxBx.TabIndex = 0;
            // 
            // contactNumberTxBx
            // 
            this.contactNumberTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTxBx.Location = new System.Drawing.Point(318, 114);
            this.contactNumberTxBx.Name = "contactNumberTxBx";
            this.contactNumberTxBx.Size = new System.Drawing.Size(112, 20);
            this.contactNumberTxBx.TabIndex = 0;
            // 
            // emailTxBx
            // 
            this.emailTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxBx.Location = new System.Drawing.Point(110, 114);
            this.emailTxBx.Name = "emailTxBx";
            this.emailTxBx.Size = new System.Drawing.Size(112, 20);
            this.emailTxBx.TabIndex = 0;
            // 
            // password2TxBx
            // 
            this.password2TxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2TxBx.Location = new System.Drawing.Point(110, 86);
            this.password2TxBx.Name = "password2TxBx";
            this.password2TxBx.Size = new System.Drawing.Size(112, 20);
            this.password2TxBx.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "lastname:";
            // 
            // passwordTxBx
            // 
            this.passwordTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxBx.Location = new System.Drawing.Point(110, 58);
            this.passwordTxBx.Name = "passwordTxBx";
            this.passwordTxBx.Size = new System.Drawing.Size(112, 20);
            this.passwordTxBx.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "birthdate:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "firstname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(228, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "contact number:";
            // 
            // usernameTxBx
            // 
            this.usernameTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxBx.Location = new System.Drawing.Point(111, 30);
            this.usernameTxBx.Name = "usernameTxBx";
            this.usernameTxBx.Size = new System.Drawing.Size(112, 20);
            this.usernameTxBx.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "comfirm password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(274, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "username:";
            // 
            // doctorRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "doctorRegistration";
            this.Text = "Doctor Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usernameTxBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password2TxBx;
        private System.Windows.Forms.TextBox passwordTxBx;
        private System.Windows.Forms.RadioButton maleRadBtn;
        private System.Windows.Forms.RadioButton femaleRadBtn;
        private System.Windows.Forms.ComboBox roomCmbBx;
        private System.Windows.Forms.TextBox lastnameTxBx;
        private System.Windows.Forms.TextBox firstnameTxBx;
        private System.Windows.Forms.TextBox contactNumberTxBx;
        private System.Windows.Forms.TextBox emailTxBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addressTxBx;
        private System.Windows.Forms.Label label11;
    }
}