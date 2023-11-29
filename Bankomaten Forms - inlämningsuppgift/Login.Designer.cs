namespace Bankomaten_Forms___inlämningsuppgift
{
    partial class Login
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
            welcomelabel = new Label();
            choiceLabel = new Label();
            insertCardButton = new Button();
            exitButton = new Button();
            seeBankAccountsLabel = new Button();
            SuspendLayout();
            // 
            // welcomelabel
            // 
            welcomelabel.AutoSize = true;
            welcomelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            welcomelabel.Location = new Point(273, 39);
            welcomelabel.Name = "welcomelabel";
            welcomelabel.Size = new Size(246, 31);
            welcomelabel.TabIndex = 8;
            welcomelabel.Text = "Welcome to the ATM!";
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            choiceLabel.Location = new Point(287, 111);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(223, 28);
            choiceLabel.TabIndex = 11;
            choiceLabel.Text = "Choose an alternative:";
            // 
            // insertCardButton
            // 
            insertCardButton.Location = new Point(353, 243);
            insertCardButton.Name = "insertCardButton";
            insertCardButton.Size = new Size(94, 37);
            insertCardButton.TabIndex = 12;
            insertCardButton.Text = "Insert Card";
            insertCardButton.UseVisualStyleBackColor = true;
            insertCardButton.Click += insertCardButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(353, 304);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 31);
            exitButton.TabIndex = 13;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // seeBankAccountsLabel
            // 
            seeBankAccountsLabel.Location = new Point(321, 178);
            seeBankAccountsLabel.Name = "seeBankAccountsLabel";
            seeBankAccountsLabel.Size = new Size(165, 40);
            seeBankAccountsLabel.TabIndex = 14;
            seeBankAccountsLabel.Text = "See Bank Accounts";
            seeBankAccountsLabel.UseVisualStyleBackColor = true;
            seeBankAccountsLabel.Click += seeBankAccountsLabel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(seeBankAccountsLabel);
            Controls.Add(exitButton);
            Controls.Add(insertCardButton);
            Controls.Add(choiceLabel);
            Controls.Add(welcomelabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomelabel;
        private Label choiceLabel;
        private Button insertCardButton;
        private Button exitButton;
        private Button seeBankAccountsLabel;
    }
}