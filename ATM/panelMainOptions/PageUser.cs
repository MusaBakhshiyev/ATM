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
    public partial class PageUser : UserControl
    {
        public PageUser()
        {
            InitializeComponent();
            labelUser.Text = User.Name + " " + User.Surname;
            labelDateOfBirth.Text = "Date Of Birth: " + User.DateOfBirth.ToShortDateString();
            labelPhoneNumber.Text = "Phone Number: " + User.PhoneNumber;
            labelCardNumber.Text = "Card Number: " + User.CardNumber;
            labelPIN.Text = "PIN: " + User.PIN;
            labelBalance.Text = "Balance: " + User.Balance.ToString();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.ParentForm.Hide();
            formLogin.Show();
        }
    }
    public class User
    {
        public static string Name;
        public static string Surname;
        public static DateTime DateOfBirth;
        public static string CardNumber;
        public static string PIN;
        public static string PhoneNumber;
        public static int Balance;
    }
}
