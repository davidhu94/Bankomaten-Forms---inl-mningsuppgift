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
    public partial class InsertMoney : Form
    {
        private atmForm atmForm;

        private UserAccount loggedInAccount;
        public InsertMoney(atmForm atmform, UserAccount loggedInAccount)
        {
            InitializeComponent();
            this.atmForm = atmform;
            this.loggedInAccount = loggedInAccount;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            atmForm.Show();
            this.Hide();
        }

        private void inputAmountButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount;
                amount = decimal.Parse(inputAmountTextBox.Text);
                DepositMoney(amount);
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("You can only write numbers!");
            }
        }

        private void insertFiveButton_Click(object sender, EventArgs e)
        {
            DepositMoney(5);
        }

        private void insertTenButton_Click(object sender, EventArgs e)
        {
            DepositMoney(10);
        }

        private void insertTwentyButton_Click(object sender, EventArgs e)
        {
            DepositMoney(20);
        }

        private void insertFiftyButton_Click(object sender, EventArgs e)
        {
            DepositMoney(50);
        }

        private void insertHundredButton_Click(object sender, EventArgs e)
        {
            DepositMoney(100);
        }

        private void insertTwoHundredButton_Click(object sender, EventArgs e)
        {
            DepositMoney(200);
        }

        private void insertFiveHundredButton_Click(object sender, EventArgs e)
        {
            DepositMoney(500);
        }

        private void insertThousandButton_Click(object sender, EventArgs e)
        {
            DepositMoney(1000);
        }

        private void DepositMoney(decimal amount)
        {
            loggedInAccount.Balance += amount;
            MessageBox.Show($"You have successfully deposited {amount} kr. Your current balance is: {loggedInAccount.Balance} kr");
        }
    }
}
