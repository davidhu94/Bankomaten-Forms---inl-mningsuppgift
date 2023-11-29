using Microsoft.VisualBasic.Logging;


namespace Bankomaten_Forms___inlämningsuppgift
{
    public partial class atmForm : Form
    {
        
        private PinForm pinForm;
        private List<UserAccount> userAccounts;
        private WithdrawMoney withdrawMoney;
        private InsertMoney insertMoney;
        private UserAccount loggedInAccount;


        public atmForm(PinForm pinForm, UserAccount loggedInAccount, List<UserAccount> userAccounts)
        {
            InitializeComponent();
            this.pinForm = pinForm;
            this.userAccounts = userAccounts;
            this.insertMoney = new InsertMoney(this, loggedInAccount);
            this.withdrawMoney = new WithdrawMoney(this, loggedInAccount);
            this.loggedInAccount = loggedInAccount;
        }

        public atmForm()
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void seeBankAccountsLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            pinForm.Show();
            this.Hide();
        }

        private void insertMoneyButton_Click(object sender, EventArgs e)
        {
            insertMoney.Show();
            this.Hide();
        }

        private void withdrawMoneyButton_Click(object sender, EventArgs e)
        {
            withdrawMoney.Show();
            this.Hide();
        }
    }
}