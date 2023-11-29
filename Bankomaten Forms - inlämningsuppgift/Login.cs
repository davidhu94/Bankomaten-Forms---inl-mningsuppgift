using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomaten_Forms___inlämningsuppgift
{
    


    public partial class Login : Form
    {

        private List<UserAccount> userAccounts = new List<UserAccount>();


        public Login()
        {
            InitializeComponent();
            userAccounts.Add(new UserAccount(123456, 1234, 1000));
            userAccounts.Add(new UserAccount(789012, 5678, 2000));

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void insertCardButton_Click(object sender, EventArgs e)
        {
            PinForm pinForm = new PinForm(this, new atmForm(), userAccounts);
            pinForm.Show();
            this.Hide();
        }

        private void seeBankAccountsLabel_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount(this, userAccounts);
            bankAccount.Show();
            this.Hide();
        }
    }
}
