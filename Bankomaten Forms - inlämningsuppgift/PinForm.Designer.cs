namespace Bankomaten_Forms___inlämningsuppgift
{
    partial class PinForm
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
            enterButton = new Button();
            backButton = new Button();
            pinTextBox = new TextBox();
            accountNumberTextBox = new TextBox();
            pinLabel = new Label();
            accountNumberLabel = new Label();
            welcomePinLabel = new Label();
            SuspendLayout();
            // 
            // enterButton
            // 
            enterButton.Location = new Point(357, 296);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(94, 29);
            enterButton.TabIndex = 0;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += enterButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(0, 0);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // pinTextBox
            // 
            pinTextBox.Location = new Point(347, 225);
            pinTextBox.Name = "pinTextBox";
            pinTextBox.PasswordChar = '*';
            pinTextBox.Size = new Size(125, 27);
            pinTextBox.TabIndex = 1;
            // 
            // accountNumberTextBox
            // 
            accountNumberTextBox.Location = new Point(347, 167);
            accountNumberTextBox.Name = "accountNumberTextBox";
            accountNumberTextBox.Size = new Size(125, 27);
            accountNumberTextBox.TabIndex = 1;
            // 
            // pinLabel
            // 
            pinLabel.AutoSize = true;
            pinLabel.Location = new Point(253, 228);
            pinLabel.Name = "pinLabel";
            pinLabel.Size = new Size(32, 20);
            pinLabel.TabIndex = 2;
            pinLabel.Text = "Pin:";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new Point(208, 174);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(124, 20);
            accountNumberLabel.TabIndex = 2;
            accountNumberLabel.Text = "Account Number:";
            // 
            // welcomePinLabel
            // 
            welcomePinLabel.AutoSize = true;
            welcomePinLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            welcomePinLabel.Location = new Point(253, 79);
            welcomePinLabel.Name = "welcomePinLabel";
            welcomePinLabel.Size = new Size(312, 31);
            welcomePinLabel.TabIndex = 2;
            welcomePinLabel.Text = "Please enter you credentials";
            // 
            // PinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(welcomePinLabel);
            Controls.Add(accountNumberLabel);
            Controls.Add(pinLabel);
            Controls.Add(accountNumberTextBox);
            Controls.Add(pinTextBox);
            Controls.Add(backButton);
            Controls.Add(enterButton);
            Name = "PinForm";
            Text = "PinForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterButton;
        private Button backButton;
        private TextBox pinTextBox;
        private TextBox accountNumberTextBox;
        private Label pinLabel;
        private Label accountNumberLabel;
        private Label welcomePinLabel;
    }
}