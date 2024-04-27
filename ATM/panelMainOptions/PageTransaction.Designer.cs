namespace ATM.panelMainOptions
{
    partial class PageTransaction
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
            dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTransaction
            // 
            dataGridViewTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTransaction.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewTransaction.Location = new System.Drawing.Point(0, 0);
            dataGridViewTransaction.Name = "dataGridViewTransaction";
            dataGridViewTransaction.RowTemplate.Height = 25;
            dataGridViewTransaction.Size = new System.Drawing.Size(595, 450);
            dataGridViewTransaction.TabIndex = 0;
            // 
            // PageTransaction
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dataGridViewTransaction);
            Name = "PageTransaction";
            Size = new System.Drawing.Size(595, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransaction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransaction;
    }
}
