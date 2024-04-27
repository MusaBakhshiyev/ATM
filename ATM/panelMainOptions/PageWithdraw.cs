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
    public partial class PageWithdraw : UserControl
    {
        const string constr = @"Server=.\SQLEXPRESS;Database=ATM;User Id=sa;Password=BaMu2005.;TrustServerCertificate=True;";

        public PageWithdraw()
        {
            InitializeComponent();
            labelBalance.Text = "Balance: " + User.Balance;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            var choice = MessageBox.Show("Are you sure you want to make a withdraw?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (choice == DialogResult.Yes)
            {
                using (var connection = new SqlConnection(constr))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = $"select Balance from Users where CardNumber={User.CardNumber}";
                    var data = command.ExecuteReader();
                    if (data.Read())
                    {
                        User.Balance = data.GetInt32(0);
                    }
                }
                if (User.Balance - int.Parse(textBoxAmount.Text) >= 0)
                {
                    SqlTransaction transaction;
                    using (var connection = new SqlConnection(constr))
                    {
                        connection.Open();
                        transaction = connection.BeginTransaction();
                        var command = connection.CreateCommand();
                        var command2 = connection.CreateCommand();
                        command.Transaction = transaction;
                        command2.Transaction = transaction;
                        command.CommandText = $"update Users set Balance =@B where CardNumber={User.CardNumber}";
                        command2.CommandText = $"insert into transactions values (@S,'Withdraw',@R,@A,'{DateTime.Now}')";
                        command.Parameters.AddWithValue("@B", User.Balance - int.Parse(textBoxAmount.Text));
                        command2.Parameters.AddWithValue("S",User.CardNumber);
                        command2.Parameters.AddWithValue("R",User.CardNumber);
                        command2.Parameters.AddWithValue("A",textBoxAmount.Text);
                        try
                        {
                            command.ExecuteNonQuery();
                            command2.ExecuteNonQuery();
                            transaction.Commit();
                            User.Balance -= int.Parse(textBoxAmount.Text);
                            labelBalance.Text = "Balance: " + User.Balance;
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                        textBoxAmount.ResetText();
                    }
                }
                else
                {
                    MessageBox.Show("There is not enough money to withdraw money", "",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
        }
    }
}
