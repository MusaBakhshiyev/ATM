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

namespace ATM
{
    public partial class FormSignUp : Form
    {
        const string constr = @"Server=.\SQLEXPRESS;Database=ATM;User Id=sa;Password=BaMu2005.;TrustServerCertificate=True;";

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "insert into Users values (@N,@SN,@CN,@P,@PN,@DOB,0)";
                command.Parameters.AddWithValue("@N", textBoxName.Text);
                command.Parameters.AddWithValue("@SN", textBoxSurname.Text);
                command.Parameters.AddWithValue("@CN", textBoxCardNumber.Text);
                command.Parameters.AddWithValue("@P", textBoxPIN.Text);
                command.Parameters.AddWithValue("@PN", textBoxPhoneNumber.Text);
                command.Parameters.AddWithValue("@DOB", dateTimePickerDateOfBirth.Value);
                bool isEmpty = false;
                foreach (Control control in panelSignUp.Controls)
                {
                    if (control.Text == "")
                    {
                        isEmpty = true;
                        break;
                    }
                }
                if (!isEmpty)
                {
                    if (textBoxPIN.Text.Length == 4)
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("You signed up successfully");
                    }
                    else
                    {
                        MessageBox.Show("Length of PIN should be 4", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("You must enter all information", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin form1 = new FormLogin();
            form1.Show();

        }

        private void FormSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
