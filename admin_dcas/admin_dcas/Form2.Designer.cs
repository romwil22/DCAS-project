
namespace admin_dcas
{
    partial class adminProfile
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
            this.logBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.appointmentBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recordLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recordGridView = new System.Windows.Forms.DataGridView();
            this.accountBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(16, 94);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(75, 23);
            this.logBtn.TabIndex = 0;
            this.logBtn.Text = "logs";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // doctorBtn
            // 
            this.doctorBtn.Location = new System.Drawing.Point(16, 123);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(75, 23);
            this.doctorBtn.TabIndex = 0;
            this.doctorBtn.Text = "doctor";
            this.doctorBtn.UseVisualStyleBackColor = true;
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click);
            // 
            // patientBtn
            // 
            this.patientBtn.Location = new System.Drawing.Point(16, 152);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(75, 23);
            this.patientBtn.TabIndex = 0;
            this.patientBtn.Text = "patient";
            this.patientBtn.UseVisualStyleBackColor = true;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // appointmentBtn
            // 
            this.appointmentBtn.Location = new System.Drawing.Point(16, 181);
            this.appointmentBtn.Name = "appointmentBtn";
            this.appointmentBtn.Size = new System.Drawing.Size(75, 23);
            this.appointmentBtn.TabIndex = 0;
            this.appointmentBtn.Text = "appointment";
            this.appointmentBtn.UseVisualStyleBackColor = true;
            this.appointmentBtn.Click += new System.EventHandler(this.appointmentBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "register";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "record";
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordLabel.Location = new System.Drawing.Point(127, 40);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(156, 24);
            this.recordLabel.TabIndex = 1;
            this.recordLabel.Text = "Accounts Record";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "doctor";
            // 
            // recordGridView
            // 
            this.recordGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recordGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGridView.Location = new System.Drawing.Point(131, 67);
            this.recordGridView.Name = "recordGridView";
            this.recordGridView.Size = new System.Drawing.Size(790, 516);
            this.recordGridView.TabIndex = 2;
            // 
            // accountBtn
            // 
            this.accountBtn.Location = new System.Drawing.Point(16, 67);
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.Size = new System.Drawing.Size(75, 23);
            this.accountBtn.TabIndex = 0;
            this.accountBtn.Text = "account";
            this.accountBtn.UseVisualStyleBackColor = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // adminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 595);
            this.Controls.Add(this.recordGridView);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.appointmentBtn);
            this.Controls.Add(this.patientBtn);
            this.Controls.Add(this.doctorBtn);
            this.Controls.Add(this.accountBtn);
            this.Controls.Add(this.logBtn);
            this.Name = "adminProfile";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.adminProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Button appointmentBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label recordLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView recordGridView;
        private System.Windows.Forms.Button accountBtn;
    }
}