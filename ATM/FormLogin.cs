using ATM.panelMainOptions;
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
    public partial class FormLogin : Form
    {
        const string constr = @"Server=.\SQLEXPRESS;Database=ATM;User Id=sa;Password=BaMu2005.;TrustServerCertificate=True;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (var connnection = new SqlConnection(constr))
            {
                connnection.Open();
                var command = connnection.CreateCommand();
                command.CommandText = $"select Name,Surname,DateOfBirth,CardNumber,PIN,PhoneNumber,Balance from users where CardNumber = @CN and PIN =@P";
                command.Parameters.AddWithValue("CN", textBoxCardNumber.Text);
                command.Parameters.AddWithValue("P", textBoxPIN.Text);
                var data = command.ExecuteReader();
                if (data.Read())
                {
                    this.Hide();
                    FormMain formMain = new FormMain();
                    User.Name = data.GetString(0);
                    User.Surname = data.GetString(1);
                    User.DateOfBirth = data.GetDateTime(2);
                    User.CardNumber = data.GetString(3);
                    User.PIN = data.GetString(4);
                    User.PhoneNumber = data.GetString(5);
                    User.Balance = data.GetInt32(6);


                    PageUser pageUser = new PageUser();
                    pageUser.Dock = DockStyle.Fill;
                    formMain.panelSelectedOption.Controls.Add(pageUser);
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("There is no such user", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
    
}
