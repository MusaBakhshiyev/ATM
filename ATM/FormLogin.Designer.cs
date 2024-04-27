namespace ATM
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panelLogin = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            labelLogin = new System.Windows.Forms.Label();
            labelPIN = new System.Windows.Forms.Label();
            labelCardNumber = new System.Windows.Forms.Label();
            textBoxPIN = new System.Windows.Forms.TextBox();
            textBoxCardNumber = new System.Windows.Forms.TextBox();
            buttonSignup = new System.Windows.Forms.Button();
            pictureBoxATM = new System.Windows.Forms.PictureBox();
            buttonLogin = new System.Windows.Forms.Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxATM).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(labelLogin);
            panelLogin.Controls.Add(labelPIN);
            panelLogin.Controls.Add(labelCardNumber);
            panelLogin.Controls.Add(textBoxPIN);
            panelLogin.Controls.Add(textBoxCardNumber);
            panelLogin.Controls.Add(buttonSignup);
            panelLogin.Controls.Add(pictureBoxATM);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            panelLogin.Location = new System.Drawing.Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new System.Drawing.Size(675, 438);
            panelLogin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 310);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 25);
            label1.TabIndex = 7;
            label1.Text = "Don't have an account?";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelLogin.Location = new System.Drawing.Point(3, 43);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new System.Drawing.Size(292, 32);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Login with your account";
            // 
            // labelPIN
            // 
            labelPIN.AutoSize = true;
            labelPIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPIN.Location = new System.Drawing.Point(12, 156);
            labelPIN.Name = "labelPIN";
            labelPIN.Size = new System.Drawing.Size(38, 21);
            labelPIN.TabIndex = 6;
            labelPIN.Text = "PIN";
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCardNumber.Location = new System.Drawing.Point(12, 94);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new System.Drawing.Size(112, 21);
            labelCardNumber.TabIndex = 5;
            labelCardNumber.Text = "Card Number";
            // 
            // textBoxPIN
            // 
            textBoxPIN.Location = new System.Drawing.Point(12, 180);
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.Size = new System.Drawing.Size(220, 23);
            textBoxPIN.TabIndex = 2;
            textBoxPIN.UseSystemPasswordChar = true;
            // 
            // textBoxCardNumber
            // 
            textBoxCardNumber.Location = new System.Drawing.Point(12, 118);
            textBoxCardNumber.Name = "textBoxCardNumber";
            textBoxCardNumber.Size = new System.Drawing.Size(220, 23);
            textBoxCardNumber.TabIndex = 1;
            // 
            // buttonSignup
            // 
            buttonSignup.BackColor = System.Drawing.Color.LightSlateGray;
            buttonSignup.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSignup.ForeColor = System.Drawing.Color.White;
            buttonSignup.Location = new System.Drawing.Point(12, 349);
            buttonSignup.Name = "buttonSignup";
            buttonSignup.Size = new System.Drawing.Size(112, 44);
            buttonSignup.TabIndex = 4;
            buttonSignup.Text = "SIGN UP";
            buttonSignup.UseVisualStyleBackColor = false;
            buttonSignup.Click += buttonSignup_Click;
            // 
            // pictureBoxATM
            // 
            pictureBoxATM.Image = (System.Drawing.Image)resources.GetObject("pictureBoxATM.Image");
            pictureBoxATM.Location = new System.Drawing.Point(385, 100);
            pictureBoxATM.Name = "pictureBoxATM";
            pictureBoxATM.Size = new System.Drawing.Size(250, 232);
            pictureBoxATM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxATM.TabIndex = 1;
            pictureBoxATM.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = System.Drawing.Color.SteelBlue;
            buttonLogin.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonLogin.ForeColor = System.Drawing.Color.White;
            buttonLogin.Location = new System.Drawing.Point(12, 230);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new System.Drawing.Size(112, 44);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(675, 438);
            Controls.Add(panelLogin);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ATM";
            FormClosed += FormLogin_FormClosed;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxATM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public  System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.PictureBox pictureBoxATM;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label1;
    }
}
