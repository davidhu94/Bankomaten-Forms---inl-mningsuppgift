namespace Bankomaten_Forms___inlämningsuppgift
{
    partial class InsertMoney
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
            insertAmountLabel = new Label();
            insertFiveButton = new Button();
            insertTenButton = new Button();
            insertTwentyButton = new Button();
            insertFiftyButton = new Button();
            insertHundredButton = new Button();
            insertTwoHundredButton = new Button();
            insertFiveHundredButton = new Button();
            insertThousandButton = new Button();
            inputAmountButton = new Button();
            inputAmountLabel = new Label();
            inputAmountTextBox = new TextBox();
            backButton = new Button();
            SuspendLayout();
            // 
            // insertAmountLabel
            // 
            insertAmountLabel.AutoSize = true;
            insertAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            insertAmountLabel.Location = new Point(209, 43);
            insertAmountLabel.Name = "insertAmountLabel";
            insertAmountLabel.Size = new Size(400, 31);
            insertAmountLabel.TabIndex = 0;
            insertAmountLabel.Text = "How much would you like to insert?";
            // 
            // insertFiveButton
            // 
            insertFiveButton.Location = new Point(265, 122);
            insertFiveButton.Name = "insertFiveButton";
            insertFiveButton.Size = new Size(94, 29);
            insertFiveButton.TabIndex = 1;
            insertFiveButton.Text = "5";
            insertFiveButton.UseVisualStyleBackColor = true;
            insertFiveButton.Click += insertFiveButton_Click;
            // 
            // insertTenButton
            // 
            insertTenButton.Location = new Point(265, 185);
            insertTenButton.Name = "insertTenButton";
            insertTenButton.Size = new Size(94, 29);
            insertTenButton.TabIndex = 1;
            insertTenButton.Text = "10";
            insertTenButton.UseVisualStyleBackColor = true;
            insertTenButton.Click += insertTenButton_Click;
            // 
            // insertTwentyButton
            // 
            insertTwentyButton.Location = new Point(265, 242);
            insertTwentyButton.Name = "insertTwentyButton";
            insertTwentyButton.Size = new Size(94, 29);
            insertTwentyButton.TabIndex = 1;
            insertTwentyButton.Text = "20";
            insertTwentyButton.UseVisualStyleBackColor = true;
            insertTwentyButton.Click += insertTwentyButton_Click;
            // 
            // insertFiftyButton
            // 
            insertFiftyButton.Location = new Point(265, 299);
            insertFiftyButton.Name = "insertFiftyButton";
            insertFiftyButton.Size = new Size(94, 29);
            insertFiftyButton.TabIndex = 1;
            insertFiftyButton.Text = "50";
            insertFiftyButton.UseVisualStyleBackColor = true;
            insertFiftyButton.Click += insertFiftyButton_Click;
            // 
            // insertHundredButton
            // 
            insertHundredButton.Location = new Point(401, 122);
            insertHundredButton.Name = "insertHundredButton";
            insertHundredButton.Size = new Size(94, 29);
            insertHundredButton.TabIndex = 1;
            insertHundredButton.Text = "100";
            insertHundredButton.UseVisualStyleBackColor = true;
            insertHundredButton.Click += insertHundredButton_Click;
            // 
            // insertTwoHundredButton
            // 
            insertTwoHundredButton.Location = new Point(401, 185);
            insertTwoHundredButton.Name = "insertTwoHundredButton";
            insertTwoHundredButton.Size = new Size(94, 29);
            insertTwoHundredButton.TabIndex = 1;
            insertTwoHundredButton.Text = "200";
            insertTwoHundredButton.UseVisualStyleBackColor = true;
            insertTwoHundredButton.Click += insertTwoHundredButton_Click;
            // 
            // insertFiveHundredButton
            // 
            insertFiveHundredButton.Location = new Point(401, 242);
            insertFiveHundredButton.Name = "insertFiveHundredButton";
            insertFiveHundredButton.Size = new Size(94, 29);
            insertFiveHundredButton.TabIndex = 1;
            insertFiveHundredButton.Text = "500";
            insertFiveHundredButton.UseVisualStyleBackColor = true;
            insertFiveHundredButton.Click += insertFiveHundredButton_Click;
            // 
            // insertThousandButton
            // 
            insertThousandButton.Location = new Point(401, 299);
            insertThousandButton.Name = "insertThousandButton";
            insertThousandButton.Size = new Size(94, 29);
            insertThousandButton.TabIndex = 1;
            insertThousandButton.Text = "1000";
            insertThousandButton.UseVisualStyleBackColor = true;
            insertThousandButton.Click += insertThousandButton_Click;
            // 
            // inputAmountButton
            // 
            inputAmountButton.Location = new Point(515, 375);
            inputAmountButton.Name = "inputAmountButton";
            inputAmountButton.Size = new Size(94, 29);
            inputAmountButton.TabIndex = 2;
            inputAmountButton.Text = "Enter";
            inputAmountButton.UseVisualStyleBackColor = true;
            inputAmountButton.Click += inputAmountButton_Click;
            // 
            // inputAmountLabel
            // 
            inputAmountLabel.AutoSize = true;
            inputAmountLabel.Location = new Point(177, 378);
            inputAmountLabel.Name = "inputAmountLabel";
            inputAmountLabel.Size = new Size(164, 20);
            inputAmountLabel.TabIndex = 3;
            inputAmountLabel.Text = "Or put another amount:";
            // 
            // inputAmountTextBox
            // 
            inputAmountTextBox.Location = new Point(360, 375);
            inputAmountTextBox.Name = "inputAmountTextBox";
            inputAmountTextBox.Size = new Size(125, 27);
            inputAmountTextBox.TabIndex = 4;
            // 
            // backButton
            // 
            backButton.Location = new Point(-1, 1);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // InsertMoney
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputAmountTextBox);
            Controls.Add(inputAmountLabel);
            Controls.Add(backButton);
            Controls.Add(inputAmountButton);
            Controls.Add(insertThousandButton);
            Controls.Add(insertFiftyButton);
            Controls.Add(insertFiveHundredButton);
            Controls.Add(insertTwentyButton);
            Controls.Add(insertTwoHundredButton);
            Controls.Add(insertTenButton);
            Controls.Add(insertHundredButton);
            Controls.Add(insertFiveButton);
            Controls.Add(insertAmountLabel);
            Name = "InsertMoney";
            Text = "InsertMoney";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label insertAmountLabel;
        private Button insertFiveButton;
        private Button insertTenButton;
        private Button insertTwentyButton;
        private Button insertFiftyButton;
        private Button insertHundredButton;
        private Button insertTwoHundredButton;
        private Button insertFiveHundredButton;
        private Button insertThousandButton;
        private Button inputAmountButton;
        private Label inputAmountLabel;
        private TextBox inputAmountTextBox;
        private Button backButton;
    }
}