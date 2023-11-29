using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomaten_Forms___inlämningsuppgift
{
    public partial class BankAccount : Form
    {
        private List<UserAccount> userAccounts;
        private Login loginForm;

        public BankAccount(Login loginForm, List<UserAccount> userAccounts)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.userAccounts = userAccounts;
            LoadBankAccountsToListBox();

        }
        private void SaveDataToFile()
        {
            try
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "bank_data.csv");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (UserAccount userAccount in userAccounts)
                    {
                        string accountInfo = $"{userAccount.AccountNumber},{userAccount.Pin},{userAccount.Balance}";
                        writer.WriteLine(accountInfo);
                        
                        
                    }
                }
                MessageBox.Show("Accounts saved!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data: " + ex.Message);
            }

        }

        private void LoadDataFromFile()
        {
            try
            {
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "bank_data.csv");

                if (File.Exists(filePath))
                {
                    userAccounts.Clear();

                    using (StreamReader streamReader = new StreamReader(filePath))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            string[] accountInfo = streamReader.ReadLine().Split(',');
                            int accountNumber = int.Parse(accountInfo[0]);
                            int pin = int.Parse(accountInfo[1]);
                            decimal balance = decimal.Parse(accountInfo[2]);

                            UserAccount userAccount = new UserAccount(accountNumber, pin, balance);
                            userAccounts.Add(userAccount);
                        }
                    }

                    UpdateListBox();
                    MessageBox.Show("Accounts loaded!");
                }
                else
                {
                    MessageBox.Show("'bank_data.csv' was not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);

            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {

            loginForm.Show();
            this.Hide();
        }

        private void LoadBankAccountsToListBox()
        {
            foreach (UserAccount account in userAccounts)
            {
                string accountInfo = $"Account Number: {account.AccountNumber}, Pin: {account.Pin}, Balance: {account.Balance} kr";
                bankAccountsListBox.Items.Add(accountInfo);
            }
        }

        private void UpdateListBox()
        {
            bankAccountsListBox.Items.Clear();
            LoadBankAccountsToListBox();

        }



        private void bankAccountAddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(accountNumberTextBox.Text) ||
                string.IsNullOrWhiteSpace(accountPinTextBox.Text) ||
                string.IsNullOrWhiteSpace(accountBalanceTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                int pin = int.Parse(accountPinTextBox.Text);
                decimal balance = decimal.Parse(accountBalanceTextBox.Text);
                int account = int.Parse(accountNumberTextBox.Text);

                UserAccount userAccount = new UserAccount(account, pin, balance);

                userAccounts.Add(userAccount);
                UpdateListBox();
                accountNumberTextBox.Clear();
                accountPinTextBox.Clear();
                accountBalanceTextBox.Clear();
            }
            catch
            {
                MessageBox.Show("Invalid input. Pin and balance must be numeric values.");
            }

        }

        private void bankAccountRemoveButton_Click(object sender, EventArgs e)
        {
            if (bankAccountsListBox.SelectedItem != null)
            {
                userAccounts.RemoveAt(bankAccountsListBox.SelectedIndex);
                UpdateListBox();

            }
            else
            {
                MessageBox.Show("Please select an account to remove.");
            }

        }

        private void saveAccountsButton_Click(object sender, EventArgs e)
        {
            SaveDataToFile();
        }

        private void loadAccountsButton_Click(object sender, EventArgs e)
        {
            LoadDataFromFile();
        }
    }
}
