namespace ATM.panelMainOptions
{
    partial class PageUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageUser));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            labelPhoneNumber = new System.Windows.Forms.Label();
            labelCardNumber = new System.Windows.Forms.Label();
            labelUser = new System.Windows.Forms.Label();
            labelBalance = new System.Windows.Forms.Label();
            labelDateOfBirth = new System.Windows.Forms.Label();
            labelPIN = new System.Windows.Forms.Label();
            buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(171, 129);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPhoneNumber.Location = new System.Drawing.Point(3, 221);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new System.Drawing.Size(342, 32);
            labelPhoneNumber.TabIndex = 1;
            labelPhoneNumber.Text = "Phone Number: 0551248569";
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            labelCardNumber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCardNumber.Location = new System.Drawing.Point(3, 275);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new System.Drawing.Size(239, 32);
            labelCardNumber.TabIndex = 1;
            labelCardNumber.Text = "Card Number: 1000";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = System.Drawing.Color.Transparent;
            labelUser.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelUser.Location = new System.Drawing.Point(180, 44);
            labelUser.Name = "labelUser";
            labelUser.Size = new System.Drawing.Size(304, 47);
            labelUser.TabIndex = 1;
            labelUser.Text = "Musa Bakhshiyev";
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            labelBalance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelBalance.Location = new System.Drawing.Point(3, 383);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new System.Drawing.Size(130, 32);
            labelBalance.TabIndex = 0;
            labelBalance.Text = "Balance: 0";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.BackColor = System.Drawing.SystemColors.InactiveCaption;
            labelDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelDateOfBirth.Location = new System.Drawing.Point(3, 167);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new System.Drawing.Size(298, 32);
            labelDateOfBirth.TabIndex = 1;
            labelDateOfBirth.Text = "Date Of Birth: 6/29/2005";
            // 
            // labelPIN
            // 
            labelPIN.AutoSize = true;
            labelPIN.BackColor = System.Drawing.SystemColors.InactiveCaption;
            labelPIN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPIN.Location = new System.Drawing.Point(3, 329);
            labelPIN.Name = "labelPIN";
            labelPIN.Size = new System.Drawing.Size(126, 32);
            labelPIN.TabIndex = 0;
            labelPIN.Text = "PIN: 2005";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = System.Drawing.Color.IndianRed;
            buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonLogout.ForeColor = System.Drawing.Color.White;
            buttonLogout.Location = new System.Drawing.Point(430, 375);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new System.Drawing.Size(125, 40);
            buttonLogout.TabIndex = 3;
            buttonLogout.Text = "LOG OUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // PageUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(buttonLogout);
            Controls.Add(pictureBox1);
            Controls.Add(labelDateOfBirth);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelCardNumber);
            Controls.Add(labelUser);
            Controls.Add(labelPIN);
            Controls.Add(labelBalance);
            Name = "PageUser";
            Size = new System.Drawing.Size(595, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Button buttonLogout;
    }
}
