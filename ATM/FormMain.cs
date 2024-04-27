using ATM.panelMainOptions;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void panelSelectedButtonLocation(Button button)
        {
            panelSelectedButton.Location = new Point(0, button.Location.Y + 70);
        }
        private void buttonUser_Click(object sender, EventArgs e)
        {
            panelSelectedButtonLocation(buttonUser);
            PageUser pageUser = new PageUser();
            pageUser.Dock = DockStyle.Fill;
            panelSelectedOption.Controls.Clear();
            panelSelectedOption.Controls.Add(pageUser);
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            panelSelectedButtonLocation(buttonDeposit);
            PageDeposit pageDeposit = new PageDeposit();
            pageDeposit.Dock = DockStyle.Fill;
            panelSelectedOption.Controls.Clear();
            panelSelectedOption.Controls.Add(pageDeposit);
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            panelSelectedButtonLocation(buttonWithdraw);
            PageWithdraw pageWithdraw = new PageWithdraw();
            pageWithdraw.Dock = DockStyle.Fill;
            panelSelectedOption.Controls.Clear();
            panelSelectedOption.Controls.Add(pageWithdraw);
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            panelSelectedButtonLocation(buttonTransfer);
            PageTransfer pageTransfer = new PageTransfer();
            pageTransfer.Dock = DockStyle.Fill;
            panelSelectedOption.Controls.Clear();
            panelSelectedOption.Controls.Add(pageTransfer);
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            panelSelectedButtonLocation(buttonTransaction);
            PageTransaction pageTransaction = new PageTransaction();
            pageTransaction.Dock = DockStyle.Fill;
            panelSelectedOption.Controls.Clear();
            panelSelectedOption.Controls.Add(pageTransaction);
        }

        private void buttonChangePin_Click(object sender, EventArgs e)
        {
            panelSelectedButtonLocation(buttonChangePin);
            PageChangePIN pageChangePIN = new PageChangePIN();
            pageChangePIN.Dock = DockStyle.Fill;
            panelSelectedOption.Controls.Clear();
            panelSelectedOption.Controls.Add(pageChangePIN);
        }
    }
}
