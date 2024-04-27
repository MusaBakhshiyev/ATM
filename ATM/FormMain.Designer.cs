namespace ATM
{
    partial class FormMain
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
            panelMain = new System.Windows.Forms.Panel();
            panelSelectedOption = new System.Windows.Forms.Panel();
            panelOptions = new System.Windows.Forms.Panel();
            panelSelectedButton = new System.Windows.Forms.Panel();
            buttonChangePin = new System.Windows.Forms.Button();
            buttonTransaction = new System.Windows.Forms.Button();
            buttonTransfer = new System.Windows.Forms.Button();
            buttonWithdraw = new System.Windows.Forms.Button();
            buttonDeposit = new System.Windows.Forms.Button();
            buttonUser = new System.Windows.Forms.Button();
            panelMain.SuspendLayout();
            panelOptions.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.White;
            panelMain.Controls.Add(panelSelectedOption);
            panelMain.Controls.Add(panelOptions);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(800, 450);
            panelMain.TabIndex = 0;
            // 
            // panelSelectedOption
            // 
            panelSelectedOption.Dock = System.Windows.Forms.DockStyle.Fill;
            panelSelectedOption.Location = new System.Drawing.Point(205, 0);
            panelSelectedOption.Name = "panelSelectedOption";
            panelSelectedOption.Size = new System.Drawing.Size(595, 450);
            panelSelectedOption.TabIndex = 1;
            // 
            // panelOptions
            // 
            panelOptions.BackColor = System.Drawing.Color.DarkSlateGray;
            panelOptions.Controls.Add(panelSelectedButton);
            panelOptions.Controls.Add(buttonChangePin);
            panelOptions.Controls.Add(buttonTransaction);
            panelOptions.Controls.Add(buttonTransfer);
            panelOptions.Controls.Add(buttonWithdraw);
            panelOptions.Controls.Add(buttonDeposit);
            panelOptions.Controls.Add(buttonUser);
            panelOptions.Dock = System.Windows.Forms.DockStyle.Left;
            panelOptions.Location = new System.Drawing.Point(0, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new System.Drawing.Size(205, 450);
            panelOptions.TabIndex = 0;
            // 
            // panelSelectedButton
            // 
            panelSelectedButton.BackColor = System.Drawing.Color.White;
            panelSelectedButton.Location = new System.Drawing.Point(0, 70);
            panelSelectedButton.Name = "panelSelectedButton";
            panelSelectedButton.Size = new System.Drawing.Size(205, 5);
            panelSelectedButton.TabIndex = 6;
            // 
            // buttonChangePin
            // 
            buttonChangePin.BackColor = System.Drawing.Color.Transparent;
            buttonChangePin.Dock = System.Windows.Forms.DockStyle.Top;
            buttonChangePin.FlatAppearance.BorderSize = 0;
            buttonChangePin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonChangePin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonChangePin.ForeColor = System.Drawing.Color.White;
            buttonChangePin.Location = new System.Drawing.Point(0, 375);
            buttonChangePin.Name = "buttonChangePin";
            buttonChangePin.Size = new System.Drawing.Size(205, 75);
            buttonChangePin.TabIndex = 5;
            buttonChangePin.Text = "CHANGE PIN";
            buttonChangePin.UseVisualStyleBackColor = false;
            buttonChangePin.Click += buttonChangePin_Click;
            // 
            // buttonTransaction
            // 
            buttonTransaction.BackColor = System.Drawing.Color.Transparent;
            buttonTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            buttonTransaction.FlatAppearance.BorderSize = 0;
            buttonTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonTransaction.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonTransaction.ForeColor = System.Drawing.Color.White;
            buttonTransaction.Location = new System.Drawing.Point(0, 300);
            buttonTransaction.Name = "buttonTransaction";
            buttonTransaction.Size = new System.Drawing.Size(205, 75);
            buttonTransaction.TabIndex = 4;
            buttonTransaction.Text = "TRANSACTION";
            buttonTransaction.UseVisualStyleBackColor = false;
            buttonTransaction.Click += buttonTransaction_Click;
            // 
            // buttonTransfer
            // 
            buttonTransfer.BackColor = System.Drawing.Color.Transparent;
            buttonTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            buttonTransfer.FlatAppearance.BorderSize = 0;
            buttonTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonTransfer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonTransfer.ForeColor = System.Drawing.Color.White;
            buttonTransfer.Location = new System.Drawing.Point(0, 225);
            buttonTransfer.Name = "buttonTransfer";
            buttonTransfer.Size = new System.Drawing.Size(205, 75);
            buttonTransfer.TabIndex = 3;
            buttonTransfer.Text = "TRANSFER";
            buttonTransfer.UseVisualStyleBackColor = false;
            buttonTransfer.Click += buttonTransfer_Click;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.BackColor = System.Drawing.Color.Transparent;
            buttonWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            buttonWithdraw.FlatAppearance.BorderSize = 0;
            buttonWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonWithdraw.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonWithdraw.ForeColor = System.Drawing.Color.White;
            buttonWithdraw.Location = new System.Drawing.Point(0, 150);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new System.Drawing.Size(205, 75);
            buttonWithdraw.TabIndex = 2;
            buttonWithdraw.Text = "WITHDRAW";
            buttonWithdraw.UseVisualStyleBackColor = false;
            buttonWithdraw.Click += buttonWithdraw_Click;
            // 
            // buttonDeposit
            // 
            buttonDeposit.BackColor = System.Drawing.Color.Transparent;
            buttonDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            buttonDeposit.FlatAppearance.BorderSize = 0;
            buttonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDeposit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDeposit.ForeColor = System.Drawing.Color.White;
            buttonDeposit.Location = new System.Drawing.Point(0, 75);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new System.Drawing.Size(205, 75);
            buttonDeposit.TabIndex = 1;
            buttonDeposit.Text = "DEPOSIT";
            buttonDeposit.UseVisualStyleBackColor = false;
            buttonDeposit.Click += buttonDeposit_Click;
            // 
            // buttonUser
            // 
            buttonUser.BackColor = System.Drawing.Color.Transparent;
            buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            buttonUser.FlatAppearance.BorderSize = 0;
            buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonUser.ForeColor = System.Drawing.Color.White;
            buttonUser.Location = new System.Drawing.Point(0, 0);
            buttonUser.Name = "buttonUser";
            buttonUser.Size = new System.Drawing.Size(205, 75);
            buttonUser.TabIndex = 0;
            buttonUser.Text = "USER";
            buttonUser.UseVisualStyleBackColor = false;
            buttonUser.Click += buttonUser_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panelMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FormMain";
            FormClosed += FormMain_FormClosed;
            panelMain.ResumeLayout(false);
            panelOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonChangePin;
        private System.Windows.Forms.Button buttonTransaction;
        private System.Windows.Forms.Panel panelSelectedButton;
        public System.Windows.Forms.Panel panelSelectedOption;
    }
}