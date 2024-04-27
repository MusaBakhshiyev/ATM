using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.panelMainOptions
{
    public partial class PageChangePIN : UserControl
    {
        const string constr = @"Server=.\SQLEXPRESS;Database=ATM;User Id=sa;Password=BaMu2005.;TrustServerCertificate=True;";

        public PageChangePIN()
        {
            InitializeComponent();
            labelPIN.Text = "PIN: " + User.PIN;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to change a PIN?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (choice == DialogResult.Yes)
            {
                if (textBoxNewPin.Text == textBoxConfirmNewPin.Text)
                {
                    if(textBoxNewPin.Text.Length == 4)
                    {
                        using (var connection = new SqlConnection(constr))
                        {
                            connection.Open();
                            var command = connection.CreateCommand();
                            command.CommandText = $"update Users set PIN =@P where CardNumber={User.CardNumber}";
                            command.Parameters.AddWithValue("@P", textBoxNewPin.Text);
                            command.ExecuteNonQuery();
                            User.PIN = textBoxNewPin.Text;
                            labelPIN.Text = "PIN: " + User.PIN;
                            textBoxNewPin.ResetText();
                            textBoxConfirmNewPin.ResetText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Length of PIN should be 4", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    MessageBox.Show("You should confirm a new PIN", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
