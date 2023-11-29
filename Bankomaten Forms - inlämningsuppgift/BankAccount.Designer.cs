namespace Bankomaten_Forms___inlämningsuppgift
{
    partial class BankAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bankAccountsLabel = new Label();
            bankAccountsListBox = new ListBox();
            bankAccountRemoveButton = new Button();
            accountPinTextBox = new TextBox();
            addNewAccountLabel = new Label();
            accountNumberLabel = new Label();
            pinLabel = new Label();
            accountNumberTextBox = new TextBox();
            balanceLabel = new Label();
            accountBalanceTextBox = new TextBox();
            bankAccountAddButton = new Button();
            backButton = new Button();
            saveAccountsButton = new Button();
            loadAccountsButton = new Button();
            SuspendLayout();
            // 
            // bankAccountsLabel
            // 
            bankAccountsLabel.AutoSize = true;
            bankAccountsLabel.Location = new Point(405, 72);
            bankAccountsLabel.Name = "bankAccountsLabel";
            bankAccountsLabel.Size = new Size(108, 20);
            bankAccountsLabel.TabIndex = 0;
            bankAccountsLabel.Text = "Bank Accounts:";
            // 
            // bankAccountsListBox
            // 
            bankAccountsListBox.FormattingEnabled = true;
            bankAccountsListBox.HorizontalScrollbar = true;
            bankAccountsListBox.ItemHeight = 20;
            bankAccountsListBox.Location = new Point(405, 108);
            bankAccountsListBox.MultiColumn = true;
            bankAccountsListBox.Name = "bankAccountsListBox";
            bankAccountsListBox.ScrollAlwaysVisible = true;
            bankAccountsListBox.SelectionMode = SelectionMode.MultiSimple;
            bankAccountsListBox.Size = new Size(358, 284);
            bankAccountsListBox.TabIndex = 1;
            // 
            // bankAccountRemoveButton
            // 
            bankAccountRemoveButton.Location = new Point(305, 363);
            bankAccountRemoveButton.Name = "bankAccountRemoveButton";
            bankAccountRemoveButton.Size = new Size(94, 29);
            bankAccountRemoveButton.TabIndex = 3;
            bankAccountRemoveButton.Text = "Remove";
            bankAccountRemoveButton.UseVisualStyleBackColor = true;
            bankAccountRemoveButton.Click += bankAccountRemoveButton_Click;
            // 
            // accountPinTextBox
            // 
            accountPinTextBox.Location = new Point(176, 174);
            accountPinTextBox.Name = "accountPinTextBox";
            accountPinTextBox.Size = new Size(125, 27);
            accountPinTextBox.TabIndex = 4;
            // 
            // addNewAccountLabel
            // 
            addNewAccountLabel.AutoSize = true;
            addNewAccountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addNewAccountLabel.Location = new Point(132, 27);
            addNewAccountLabel.Name = "addNewAccountLabel";
            addNewAccountLabel.Size = new Size(394, 28);
            addNewAccountLabel.TabIndex = 0;
            addNewAccountLabel.Text = "Write Information For The New Account";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new Point(38, 124);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(124, 20);
            accountNumberLabel.TabIndex = 0;
            accountNumberLabel.Text = "Account Number:";
            // 
            // pinLabel
            // 
            pinLabel.AutoSize = true;
            pinLabel.Location = new Point(38, 181);
            pinLabel.Name = "pinLabel";
            pinLabel.Size = new Size(32, 20);
            pinLabel.TabIndex = 0;
            pinLabel.Text = "Pin:";
            // 
            // accountNumberTextBox
            // 
            accountNumberTextBox.Location = new Point(176, 124);
            accountNumberTextBox.Name = "accountNumberTextBox";
            accountNumberTextBox.Size = new Size(125, 27);
            accountNumberTextBox.TabIndex = 4;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(38, 232);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(64, 20);
            balanceLabel.TabIndex = 0;
            balanceLabel.Text = "Balance:";
            // 
            // accountBalanceTextBox
            // 
            accountBalanceTextBox.Location = new Point(176, 225);
            accountBalanceTextBox.Name = "accountBalanceTextBox";
            accountBalanceTextBox.Size = new Size(125, 27);
            accountBalanceTextBox.TabIndex = 4;
            // 
            // bankAccountAddButton
            // 
            bankAccountAddButton.Location = new Point(305, 316);
            bankAccountAddButton.Name = "bankAccountAddButton";
            bankAccountAddButton.Size = new Size(94, 29);
            bankAccountAddButton.TabIndex = 3;
            bankAccountAddButton.Text = "Add";
            bankAccountAddButton.UseVisualStyleBackColor = true;
            bankAccountAddButton.Click += bankAccountAddButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(-3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 5;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // saveAccountsButton
            // 
            saveAccountsButton.Location = new Point(38, 299);
            saveAccountsButton.Name = "saveAccountsButton";
            saveAccountsButton.Size = new Size(124, 40);
            saveAccountsButton.TabIndex = 6;
            saveAccountsButton.Text = "Save Accounts";
            saveAccountsButton.UseVisualStyleBackColor = true;
            saveAccountsButton.Click += saveAccountsButton_Click;
            // 
            // loadAccountsButton
            // 
            loadAccountsButton.Location = new Point(38, 352);
            loadAccountsButton.Name = "loadAccountsButton";
            loadAccountsButton.Size = new Size(125, 40);
            loadAccountsButton.TabIndex = 6;
            loadAccountsButton.Text = "Load Accounts";
            loadAccountsButton.UseVisualStyleBackColor = true;
            loadAccountsButton.Click += loadAccountsButton_Click;
            // 
            // BankAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadAccountsButton);
            Controls.Add(saveAccountsButton);
            Controls.Add(backButton);
            Controls.Add(accountNumberTextBox);
            Controls.Add(accountBalanceTextBox);
            Controls.Add(accountPinTextBox);
            Controls.Add(bankAccountAddButton);
            Controls.Add(bankAccountRemoveButton);
            Controls.Add(bankAccountsListBox);
            Controls.Add(balanceLabel);
            Controls.Add(pinLabel);
            Controls.Add(accountNumberLabel);
            Controls.Add(addNewAccountLabel);
            Controls.Add(bankAccountsLabel);
            Name = "BankAccount";
            Text = "BankAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bankAccountsLabel;
        private ListBox bankAccountsListBox;
        private Button bankAccountRemoveButton;
        private TextBox accountPinTextBox;
        private Label addNewAccountLabel;
        private Label accountNumberLabel;
        private Label pinLabel;
        private TextBox accountNumberTextBox;
        private Label balanceLabel;
        private TextBox accountBalanceTextBox;
        private Button bankAccountAddButton;
        private Button backButton;
        private Button saveAccountsButton;
        private Button loadAccountsButton;
    }
}