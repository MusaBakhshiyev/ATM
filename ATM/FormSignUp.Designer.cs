namespace ATM
{
    partial class FormSignUp
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
            panelSignUp = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            labelEnterInfo = new System.Windows.Forms.Label();
            buttonBack = new System.Windows.Forms.Button();
            buttonSignUp = new System.Windows.Forms.Button();
            dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            textBoxPIN = new System.Windows.Forms.TextBox();
            textBoxCardNumber = new System.Windows.Forms.TextBox();
            textBoxSurname = new System.Windows.Forms.TextBox();
            textBoxName = new System.Windows.Forms.TextBox();
            labelDateOfBirth = new System.Windows.Forms.Label();
            labelPhoneNumber = new System.Windows.Forms.Label();
            labelPIN = new System.Windows.Forms.Label();
            labelCardNumber = new System.Windows.Forms.Label();
            labelSurname = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            panelSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // panelSignUp
            // 
            panelSignUp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            panelSignUp.Controls.Add(label1);
            panelSignUp.Controls.Add(labelEnterInfo);
            panelSignUp.Controls.Add(buttonBack);
            panelSignUp.Controls.Add(buttonSignUp);
            panelSignUp.Controls.Add(dateTimePickerDateOfBirth);
            panelSignUp.Controls.Add(textBoxPhoneNumber);
            panelSignUp.Controls.Add(textBoxPIN);
            panelSignUp.Controls.Add(textBoxCardNumber);
            panelSignUp.Controls.Add(textBoxSurname);
            panelSignUp.Controls.Add(textBoxName);
            panelSignUp.Controls.Add(labelDateOfBirth);
            panelSignUp.Controls.Add(labelPhoneNumber);
            panelSignUp.Controls.Add(labelPIN);
            panelSignUp.Controls.Add(labelCardNumber);
            panelSignUp.Controls.Add(labelSurname);
            panelSignUp.Controls.Add(labelName);
            panelSignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            panelSignUp.Location = new System.Drawing.Point(0, 0);
            panelSignUp.Name = "panelSignUp";
            panelSignUp.Size = new System.Drawing.Size(535, 448);
            panelSignUp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 243);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(302, 30);
            label1.TabIndex = 17;
            label1.Text = "-Enter Card Number and PIN:";
            // 
            // labelEnterInfo
            // 
            labelEnterInfo.AutoSize = true;
            labelEnterInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelEnterInfo.Location = new System.Drawing.Point(12, 31);
            labelEnterInfo.Name = "labelEnterInfo";
            labelEnterInfo.Size = new System.Drawing.Size(254, 30);
            labelEnterInfo.TabIndex = 17;
            labelEnterInfo.Text = "-Enter Your Information:";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = System.Drawing.Color.IndianRed;
            buttonBack.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonBack.ForeColor = System.Drawing.Color.White;
            buttonBack.Location = new System.Drawing.Point(158, 383);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(109, 46);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = System.Drawing.Color.SteelBlue;
            buttonSignUp.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSignUp.ForeColor = System.Drawing.Color.White;
            buttonSignUp.Location = new System.Drawing.Point(21, 383);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new System.Drawing.Size(109, 46);
            buttonSignUp.TabIndex = 7;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Location = new System.Drawing.Point(245, 111);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 23);
            dateTimePickerDateOfBirth.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new System.Drawing.Point(245, 180);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new System.Drawing.Size(200, 23);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxPIN
            // 
            textBoxPIN.Location = new System.Drawing.Point(245, 323);
            textBoxPIN.Name = "textBoxPIN";
            textBoxPIN.Size = new System.Drawing.Size(135, 23);
            textBoxPIN.TabIndex = 6;
            // 
            // textBoxCardNumber
            // 
            textBoxCardNumber.Location = new System.Drawing.Point(21, 323);
            textBoxCardNumber.Name = "textBoxCardNumber";
            textBoxCardNumber.Size = new System.Drawing.Size(165, 23);
            textBoxCardNumber.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new System.Drawing.Point(21, 180);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new System.Drawing.Size(165, 23);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new System.Drawing.Point(21, 111);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(165, 23);
            textBoxName.TabIndex = 1;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelDateOfBirth.Location = new System.Drawing.Point(245, 87);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new System.Drawing.Size(109, 21);
            labelDateOfBirth.TabIndex = 4;
            labelDateOfBirth.Text = "Date Of Birth";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPhoneNumber.Location = new System.Drawing.Point(245, 156);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new System.Drawing.Size(126, 21);
            labelPhoneNumber.TabIndex = 5;
            labelPhoneNumber.Text = "Phone Number";
            // 
            // labelPIN
            // 
            labelPIN.AutoSize = true;
            labelPIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPIN.Location = new System.Drawing.Point(245, 299);
            labelPIN.Name = "labelPIN";
            labelPIN.Size = new System.Drawing.Size(38, 21);
            labelPIN.TabIndex = 6;
            labelPIN.Text = "PIN";
            // 
            // labelCardNumber
            // 
            labelCardNumber.AutoSize = true;
            labelCardNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCardNumber.Location = new System.Drawing.Point(21, 299);
            labelCardNumber.Name = "labelCardNumber";
            labelCardNumber.Size = new System.Drawing.Size(112, 21);
            labelCardNumber.TabIndex = 7;
            labelCardNumber.Text = "Card Number";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelSurname.Location = new System.Drawing.Point(21, 156);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new System.Drawing.Size(78, 21);
            labelSurname.TabIndex = 8;
            labelSurname.Text = "Surname";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelName.Location = new System.Drawing.Point(21, 87);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(56, 21);
            labelName.TabIndex = 9;
            labelName.Text = "Name";
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(535, 448);
            Controls.Add(panelSignUp);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSignUp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormSignUp";
            FormClosed += FormSignUp_FormClosed;
            panelSignUp.ResumeLayout(false);
            panelSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEnterInfo;
        private System.Windows.Forms.Label label1;
    }
}