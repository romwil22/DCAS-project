
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.approveBtn = new System.Windows.Forms.Button();
            this.appointGridView = new System.Windows.Forms.DataGridView();
            this.rejectbutton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment";
            // 
            // approveBtn
            // 
            this.approveBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.approveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.approveBtn.Location = new System.Drawing.Point(12, 397);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(93, 47);
            this.approveBtn.TabIndex = 1;
            this.approveBtn.Text = "approve";
            this.approveBtn.UseVisualStyleBackColor = false;
            // 
            // appointGridView
            // 
            this.appointGridView.AllowUserToAddRows = false;
            this.appointGridView.AllowUserToDeleteRows = false;
            this.appointGridView.AllowUserToResizeColumns = false;
            this.appointGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.appointGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.appointGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.appointGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appointGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.appointGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.appointGridView.Location = new System.Drawing.Point(12, 105);
            this.appointGridView.Name = "appointGridView";
            this.appointGridView.ReadOnly = true;
            this.appointGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointGridView.Size = new System.Drawing.Size(733, 286);
            this.appointGridView.TabIndex = 3;
            // 
            // rejectbutton
            // 
            this.rejectbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.rejectbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rejectbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rejectbutton.Location = new System.Drawing.Point(111, 397);
            this.rejectbutton.Name = "rejectbutton";
            this.rejectbutton.Size = new System.Drawing.Size(93, 47);
            this.rejectbutton.TabIndex = 4;
            this.rejectbutton.Text = "reject";
            this.rejectbutton.UseVisualStyleBackColor = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(8, 44);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(157, 24);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Doctor Username";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.Location = new System.Drawing.Point(340, 78);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(76, 24);
            this.roomLabel.TabIndex = 6;
            this.roomLabel.Text = "Room #";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(8, 9);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(149, 24);
            this.fullnameLabel.TabIndex = 7;
            this.fullnameLabel.Text = "Doctor Fullname";
            // 
            // doctorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 456);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.rejectbutton);
            this.Controls.Add(this.appointGridView);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.label1);
            this.Name = "doctorProfile";
            this.Text = "Doctor Profile";
            this.Load += new System.EventHandler(this.doctorProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.DataGridView appointGridView;
        private System.Windows.Forms.Button rejectbutton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label fullnameLabel;
    }
}