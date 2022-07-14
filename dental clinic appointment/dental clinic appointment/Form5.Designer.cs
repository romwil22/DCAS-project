
namespace dental_clinic_appointment
{
    partial class doctorProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.approveBtn = new System.Windows.Forms.Button();
            this.appointmentGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment";
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(12, 205);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(75, 23);
            this.approveBtn.TabIndex = 1;
            this.approveBtn.Text = "approve";
            this.approveBtn.UseVisualStyleBackColor = true;
            // 
            // appointmentGridView
            // 
            this.appointmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentGridView.Location = new System.Drawing.Point(12, 36);
            this.appointmentGridView.Name = "appointmentGridView";
            this.appointmentGridView.Size = new System.Drawing.Size(733, 150);
            this.appointmentGridView.TabIndex = 2;
            // 
            // doctorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.appointmentGridView);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.label1);
            this.Name = "doctorProfile";
            this.Text = "Doctor Profile";
            this.Load += new System.EventHandler(this.doctorProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.DataGridView appointmentGridView;
    }
}