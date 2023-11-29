namespace Bankomaten_Forms___inlämningsuppgift
{
    partial class WithdrawMoney
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
            inputAmountTextBox = new TextBox();
            inputAmountLabel = new Label();
            inputAmountButton = new Button();
            withdrawThousandButton = new Button();
            withdrawFiftyButton = new Button();
            withdrawFiveHundredButton = new Button();
            withdrawTwentyButton = new Button();
            withdrawTwoHundredButton = new Button();
            withdrawTenButton = new Button();
            withdrawHundredButton = new Button();
            withdrawFiveButton = new Button();
            withdrawAmountLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // inputAmountTextBox
            // 
            inputAmountTextBox.Location = new Point(367, 377);
            inputAmountTextBox.Name = "inputAmountTextBox";
            inputAmountTextBox.Size = new Size(125, 27);
            inputAmountTextBox.TabIndex = 16;
            // 
            // inputAmountLabel
            // 
            inputAmountLabel.AutoSize = true;
            inputAmountLabel.Location = new Point(184, 380);
            inputAmountLabel.Name = "inputAmountLabel";
            inputAmountLabel.Size = new Size(164, 20);
            inputAmountLabel.TabIndex = 15;
            inputAmountLabel.Text = "Or put another amount:";
            // 
            // inputAmountButton
            // 
            inputAmountButton.Location = new Point(522, 377);
            inputAmountButton.Name = "inputAmountButton";
            inputAmountButton.Size = new Size(94, 29);
            inputAmountButton.TabIndex = 14;
            inputAmountButton.Text = "Enter";
            inputAmountButton.UseVisualStyleBackColor = true;
            inputAmountButton.Click += inputAmountButton_Click;
            // 
            // withdrawThousandButton
            // 
            withdrawThousandButton.Location = new Point(408, 301);
            withdrawThousandButton.Name = "withdrawThousandButton";
            withdrawThousandButton.Size = new Size(94, 29);
            withdrawThousandButton.TabIndex = 6;
            withdrawThousandButton.Text = "1000";
            withdrawThousandButton.UseVisualStyleBackColor = true;
            withdrawThousandButton.Click += withdrawThousandButton_Click;
            // 
            // withdrawFiftyButton
            // 
            withdrawFiftyButton.Location = new Point(272, 301);
            withdrawFiftyButton.Name = "withdrawFiftyButton";
            withdrawFiftyButton.Size = new Size(94, 29);
            withdrawFiftyButton.TabIndex = 7;
            withdrawFiftyButton.Text = "50";
            withdrawFiftyButton.UseVisualStyleBackColor = true;
            withdrawFiftyButton.Click += withdrawFiftyButton_Click;
            // 
            // withdrawFiveHundredButton
            // 
            withdrawFiveHundredButton.Location = new Point(408, 244);
            withdrawFiveHundredButton.Name = "withdrawFiveHundredButton";
            withdrawFiveHundredButton.Size = new Size(94, 29);
            withdrawFiveHundredButton.TabIndex = 8;
            withdrawFiveHundredButton.Text = "500";
            withdrawFiveHundredButton.UseVisualStyleBackColor = true;
            withdrawFiveHundredButton.Click += withdrawFiveHundredButton_Click;
            // 
            // withdrawTwentyButton
            // 
            withdrawTwentyButton.Location = new Point(272, 244);
            withdrawTwentyButton.Name = "withdrawTwentyButton";
            withdrawTwentyButton.Size = new Size(94, 29);
            withdrawTwentyButton.TabIndex = 9;
            withdrawTwentyButton.Text = "20";
            withdrawTwentyButton.UseVisualStyleBackColor = true;
            withdrawTwentyButton.Click += withdrawTwentyButton_Click;
            // 
            // withdrawTwoHundredButton
            // 
            withdrawTwoHundredButton.Location = new Point(408, 187);
            withdrawTwoHundredButton.Name = "withdrawTwoHundredButton";
            withdrawTwoHundredButton.Size = new Size(94, 29);
            withdrawTwoHundredButton.TabIndex = 10;
            withdrawTwoHundredButton.Text = "200";
            withdrawTwoHundredButton.UseVisualStyleBackColor = true;
            withdrawTwoHundredButton.Click += withdrawTwoHundredButton_Click;
            // 
            // withdrawTenButton
            // 
            withdrawTenButton.Location = new Point(272, 187);
            withdrawTenButton.Name = "withdrawTenButton";
            withdrawTenButton.Size = new Size(94, 29);
            withdrawTenButton.TabIndex = 11;
            withdrawTenButton.Text = "10";
            withdrawTenButton.UseVisualStyleBackColor = true;
            withdrawTenButton.Click += withdrawTenButton_Click;
            // 
            // withdrawHundredButton
            // 
            withdrawHundredButton.Location = new Point(408, 124);
            withdrawHundredButton.Name = "withdrawHundredButton";
            withdrawHundredButton.Size = new Size(94, 29);
            withdrawHundredButton.TabIndex = 12;
            withdrawHundredButton.Text = "100";
            withdrawHundredButton.UseVisualStyleBackColor = true;
            withdrawHundredButton.Click += withdrawHundredButton_Click;
            // 
            // withdrawFiveButton
            // 
            withdrawFiveButton.Location = new Point(272, 124);
            withdrawFiveButton.Name = "withdrawFiveButton";
            withdrawFiveButton.Size = new Size(94, 29);
            withdrawFiveButton.TabIndex = 13;
            withdrawFiveButton.Text = "5";
            withdrawFiveButton.UseVisualStyleBackColor = true;
            withdrawFiveButton.Click += withdrawFiveButton_Click;
            // 
            // withdrawAmountLabel
            // 
            withdrawAmountLabel.AutoSize = true;
            withdrawAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            withdrawAmountLabel.Location = new Point(216, 45);
            withdrawAmountLabel.Name = "withdrawAmountLabel";
            withdrawAmountLabel.Size = new Size(440, 31);
            withdrawAmountLabel.TabIndex = 5;
            withdrawAmountLabel.Text = "How much would you like to withdraw?";
            // 
            // backButton
            // 
            backButton.Location = new Point(1, 1);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 14;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // WithdrawMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputAmountTextBox);
            Controls.Add(inputAmountLabel);
            Controls.Add(backButton);
            Controls.Add(inputAmountButton);
            Controls.Add(withdrawThousandButton);
            Controls.Add(withdrawFiftyButton);
            Controls.Add(withdrawFiveHundredButton);
            Controls.Add(withdrawTwentyButton);
            Controls.Add(withdrawTwoHundredButton);
            Controls.Add(withdrawTenButton);
            Controls.Add(withdrawHundredButton);
            Controls.Add(withdrawFiveButton);
            Controls.Add(withdrawAmountLabel);
            Name = "WithdrawMoney";
            Text = "WithdrawMoney";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputAmountTextBox;
        private Label inputAmountLabel;
        private Button inputAmountButton;
        private Button withdrawThousandButton;
        private Button withdrawFiftyButton;
        private Button withdrawFiveHundredButton;
        private Button withdrawTwentyButton;
        private Button withdrawTwoHundredButton;
        private Button withdrawTenButton;
        private Button withdrawHundredButton;
        private Button withdrawFiveButton;
        private Label withdrawAmountLabel;
        private Button backButton;
    }
}