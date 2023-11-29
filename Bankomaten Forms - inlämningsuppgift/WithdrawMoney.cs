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
    public partial class WithdrawMoney : Form
    {
        private atmForm atmForm;
        private UserAccount loggedInAccount;
        public WithdrawMoney(atmForm atmForm, UserAccount loggedInAccount)
        {
            InitializeComponent();
            this.atmForm = atmForm;
            this.loggedInAccount = loggedInAccount;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            atmForm.Show();
            this.Hide();
        }

        private void withdrawFiveButton_Click(object sender, EventArgs e)
        {
            WithdrawalMoney(5);
        }

        private void withdrawTenButton_Click(object sender, EventArgs e)
        {
            WithdrawalMoney(10);
        }

        private void withdrawTwentyButton_Click(object sender, EventArgs e)
        {
            WithdrawalMoney(20);
        }

        private void withdrawFiftyButton_Click(object sender, EventArgs e)
        {
            WithdrawalMoney(50);
        }

        private void withdrawHundredButton_Click(object sender, EventArgs e)
        {
            WithdrawalMoney(100);
        }

        private void withdrawTwoHundredButton_Click(object sender, EventArgs e)
        {
            WithdrawalMoney(200);
        }

        private void withdrawFiveHundredButton_Click(object sender, EventArgs e)
        {
            WithdrawalMoney(500);
        }

        private void withdrawThousandButton_Click(object sender, EventArgs e)
        {
            WithdrawalMoney(1000);
        }

        private void inputAmountButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount;
                amount = decimal.Parse(inputAmountTextBox.Text);
                WithdrawalMoney(amount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You can only write numbers!");
            }
            
        }

        private void WithdrawalMoney(decimal amount)
        {
            if (loggedInAccount.Balance >= amount) 
            {
                loggedInAccount.Balance -= amount;
                MessageBox.Show($"You have successfully withdrawn {amount} kr. Your current balance is: {loggedInAccount.Balance} kr");
            }
            else
            {
                MessageBox.Show("You don't have that much money.");
            }
            
        }

    }
}
