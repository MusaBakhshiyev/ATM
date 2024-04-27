using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class PageTransaction : UserControl
    {
        const string constr = @"Server=.\SQLEXPRESS;Database=ATM;User Id=sa;Password=BaMu2005.;TrustServerCertificate=True;";

        public PageTransaction()
        {
            InitializeComponent();
            GetTransaction();
        }
        private void GetTransaction()
        {

            List<Transaction> transactions = new List<Transaction>();
            using (var connection = new SqlConnection(constr))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = $"select Sender,Type,Recipient,Amount,Time from transactions where Sender={User.CardNumber} or Recipient={User.CardNumber}";
                var data = command.ExecuteReader();
                while (data.Read())
                {
                    Transaction transaction = new Transaction()
                    {
                        Sender = data.GetString(0),
                        Type=data.GetString(1),
                        Recipient = data.GetString(2),
                        Amount = data.GetInt32(3),
                        Time = data.GetDateTime(4)
                    };
                    transactions.Add(transaction);
                }
            }
            dataGridViewTransaction.DataSource = transactions;
        }
    }
    public class Transaction
    {
        public string Sender { get; set; }
        public string Type { get; set; }
        public string Recipient { get; set; }
        public int Amount { get; set; }
        public DateTime Time { get; set; }
    }
}
