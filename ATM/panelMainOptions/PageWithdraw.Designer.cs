namespace ATM.panelMainOptions
{
    partial class PageWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageWithdraw));
            buttonSubmit = new System.Windows.Forms.Button();
            textBoxAmount = new System.Windows.Forms.TextBox();
            labelBalance = new System.Windows.Forms.Label();
            labelAmount = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = System.Drawing.Color.Green;
            buttonSubmit.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSubmit.ForeColor = System.Drawing.Color.White;
            buttonSubmit.Location = new System.Drawing.Point(454, 246);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new System.Drawing.Size(87, 45);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new System.Drawing.Point(293, 194);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new System.Drawing.Size(248, 23);
            textBoxAmount.TabIndex = 5;
            // 
            // labelBalance
            // 
            labelBalance.AutoSize = true;
            labelBalance.BackColor = System.Drawing.Color.SlateGray;
            labelBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelBalance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelBalance.Location = new System.Drawing.Point(0, 0);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new System.Drawing.Size(148, 39);
            labelBalance.TabIndex = 3;
            labelBalance.Text = "Balance: 0";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelAmount.Location = new System.Drawing.Point(293, 159);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new System.Drawing.Size(107, 32);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "Amount";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(268, 200);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // PageWithdraw
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxAmount);
            Controls.Add(labelBalance);
            Controls.Add(labelAmount);
            Name = "PageWithdraw";
            Size = new System.Drawing.Size(595, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
