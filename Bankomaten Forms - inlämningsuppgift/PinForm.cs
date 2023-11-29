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
    public partial class PinForm : Form
    {
        private Login login;
        private atmForm atmForm;
        private List<UserAccount> userAccounts;

        public PinForm(Login login, atmForm atmForm, List<UserAccount> userAccounts)
        {
            InitializeComponent();
            this.login = login;
            this.userAccounts = userAccounts;
            this.atmForm = atmForm;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int enteredAccountNumber = int.Parse(accountNumberTextBox.Text);
                int enteredPin = int.Parse(pinTextBox.Text);

                foreach (UserAccount user in userAccounts)
                {
                    if (user.AccountNumber == enteredAccountNumber && user.Pin == enteredPin)
                    {

                        atmForm = new atmForm(this, user, userAccounts);
                        atmForm.Show();
                        this.Hide();
                        return;



                    }
                }
                MessageBox.Show("Invalid account number or pin. Please try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Pin and balance must be numeric values.");
            }





        }
    }
}
