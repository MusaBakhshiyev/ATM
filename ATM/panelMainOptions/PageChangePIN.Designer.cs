namespace ATM.panelMainOptions
{
    partial class PageChangePIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageChangePIN));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            buttonSubmit = new System.Windows.Forms.Button();
            textBoxNewPin = new System.Windows.Forms.TextBox();
            textBoxConfirmNewPin = new System.Windows.Forms.TextBox();
            labelNewPin = new System.Windows.Forms.Label();
            labelConfirmNewPin = new System.Windows.Forms.Label();
            labelPIN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(240, 205);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = System.Drawing.Color.Green;
            buttonSubmit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSubmit.ForeColor = System.Drawing.Color.White;
            buttonSubmit.Location = new System.Drawing.Point(449, 294);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new System.Drawing.Size(87, 45);
            buttonSubmit.TabIndex = 16;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // textBoxNewPin
            // 
            textBoxNewPin.Location = new System.Drawing.Point(288, 146);
            textBoxNewPin.Name = "textBoxNewPin";
            textBoxNewPin.Size = new System.Drawing.Size(248, 23);
            textBoxNewPin.TabIndex = 14;
            // 
            // textBoxConfirmNewPin
            // 
            textBoxConfirmNewPin.Location = new System.Drawing.Point(288, 241);
            textBoxConfirmNewPin.Name = "textBoxConfirmNewPin";
            textBoxConfirmNewPin.Size = new System.Drawing.Size(248, 23);
            textBoxConfirmNewPin.TabIndex = 15;
            // 
            // labelNewPin
            // 
            labelNewPin.AutoSize = true;
            labelNewPin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelNewPin.Location = new System.Drawing.Point(288, 111);
            labelNewPin.Name = "labelNewPin";
            labelNewPin.Size = new System.Drawing.Size(114, 32);
            labelNewPin.TabIndex = 12;
            labelNewPin.Text = "New PIN";
            // 
            // labelConfirmNewPin
            // 
            labelConfirmNewPin.AutoSize = true;
            labelConfirmNewPin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelConfirmNewPin.Location = new System.Drawing.Point(288, 206);
            labelConfirmNewPin.Name = "labelConfirmNewPin";
            labelConfirmNewPin.Size = new System.Drawing.Size(214, 32);
            labelConfirmNewPin.TabIndex = 13;
            labelConfirmNewPin.Text = "Confirm New PIN";
            // 
            // labelPIN
            // 
            labelPIN.AutoSize = true;
            labelPIN.BackColor = System.Drawing.Color.LightSlateGray;
            labelPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelPIN.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelPIN.Location = new System.Drawing.Point(0, 0);
            labelPIN.Name = "labelPIN";
            labelPIN.Size = new System.Drawing.Size(144, 39);
            labelPIN.TabIndex = 12;
            labelPIN.Text = "PIN: 0000";
            // 
            // PageChangePIN
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxNewPin);
            Controls.Add(textBoxConfirmNewPin);
            Controls.Add(labelPIN);
            Controls.Add(labelNewPin);
            Controls.Add(labelConfirmNewPin);
            Name = "PageChangePIN";
            Size = new System.Drawing.Size(595, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxNewPin;
        private System.Windows.Forms.TextBox textBoxConfirmNewPin;
        private System.Windows.Forms.Label labelNewPin;
        private System.Windows.Forms.Label labelConfirmNewPin;
        private System.Windows.Forms.Label labelPIN;
    }
}
