﻿
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminTxBx
            // 
            this.adminTxBx.Location = new System.Drawing.Point(319, 129);
            this.adminTxBx.Multiline = true;
            this.adminTxBx.Name = "adminTxBx";
            this.adminTxBx.Size = new System.Drawing.Size(331, 45);
            this.adminTxBx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // passwordTxBx
            // 
            this.passwordTxBx.Location = new System.Drawing.Point(318, 185);
            this.passwordTxBx.Multiline = true;
            this.passwordTxBx.Name = "passwordTxBx";
            this.passwordTxBx.Size = new System.Drawing.Size(331, 45);
            this.passwordTxBx.TabIndex = 1;
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.SteelBlue;
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logButton.Location = new System.Drawing.Point(510, 246);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(140, 50);
            this.logButton.TabIndex = 2;
            this.logButton.Text = "Login";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // adminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 391);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.passwordTxBx);
            this.Controls.Add(this.adminTxBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminLog";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminTxBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxBx;
        private System.Windows.Forms.Button logButton;
    }
}

