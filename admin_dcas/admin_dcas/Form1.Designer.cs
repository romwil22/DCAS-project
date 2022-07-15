
namespace admin_dcas
{
    partial class adminLog
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
            this.adminTxBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxBx = new System.Windows.Forms.TextBox();
            this.logButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminTxBx
            // 
            this.adminTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTxBx.Location = new System.Drawing.Point(255, 102);
            this.adminTxBx.Multiline = true;
            this.adminTxBx.Name = "adminTxBx";
            this.adminTxBx.Size = new System.Drawing.Size(331, 45);
            this.adminTxBx.TabIndex = 1;
            this.adminTxBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminTxBx_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // passwordTxBx
            // 
            this.passwordTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxBx.Location = new System.Drawing.Point(254, 158);
            this.passwordTxBx.Multiline = true;
            this.passwordTxBx.Name = "passwordTxBx";
            this.passwordTxBx.PasswordChar = '*';
            this.passwordTxBx.Size = new System.Drawing.Size(331, 45);
            this.passwordTxBx.TabIndex = 2;
            this.passwordTxBx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTxBx_KeyDown);
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.SteelBlue;
            this.logButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logButton.Location = new System.Drawing.Point(446, 209);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(140, 50);
            this.logButton.TabIndex = 3;
            this.logButton.Text = "Login";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(44, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(662, 76);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dental Clinic Admin";
            // 
            // adminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(737, 284);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.passwordTxBx);
            this.Controls.Add(this.adminTxBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "adminLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.adminLog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminLog_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.adminLog_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.adminLog_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminTxBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxBx;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label label3;
    }
}

