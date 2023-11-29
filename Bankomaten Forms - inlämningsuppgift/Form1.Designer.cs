namespace Bankomaten_Forms___inlämningsuppgift
{
    partial class atmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitButton = new Button();
            choiceLabel = new Label();
            withdrawMoneyButton = new Button();
            insertMoneyButton = new Button();
            welcomelabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(352, 344);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            choiceLabel.Location = new Point(264, 105);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(273, 28);
            choiceLabel.TabIndex = 10;
            choiceLabel.Text = "What would you like to do?";
            // 
            // withdrawMoneyButton
            // 
            withdrawMoneyButton.Location = new Point(313, 274);
            withdrawMoneyButton.Name = "withdrawMoneyButton";
            withdrawMoneyButton.Size = new Size(165, 40);
            withdrawMoneyButton.TabIndex = 9;
            withdrawMoneyButton.Text = "Withdraw Money";
            withdrawMoneyButton.UseVisualStyleBackColor = true;
            withdrawMoneyButton.Click += withdrawMoneyButton_Click;
            // 
            // insertMoneyButton
            // 
            insertMoneyButton.Location = new Point(336, 211);
            insertMoneyButton.Name = "insertMoneyButton";
            insertMoneyButton.Size = new Size(110, 44);
            insertMoneyButton.TabIndex = 8;
            insertMoneyButton.Text = "Insert Money";
            insertMoneyButton.UseVisualStyleBackColor = true;
            insertMoneyButton.Click += insertMoneyButton_Click;
            // 
            // welcomelabel
            // 
            welcomelabel.AutoSize = true;
            welcomelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            welcomelabel.Location = new Point(264, 51);
            welcomelabel.Name = "welcomelabel";
            welcomelabel.Size = new Size(246, 31);
            welcomelabel.TabIndex = 7;
            welcomelabel.Text = "Welcome to the ATM!";
            // 
            // backButton
            // 
            backButton.Location = new Point(3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 12;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // atmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(exitButton);
            Controls.Add(choiceLabel);
            Controls.Add(withdrawMoneyButton);
            Controls.Add(insertMoneyButton);
            Controls.Add(welcomelabel);
            Name = "atmForm";
            Text = "ATM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Label choiceLabel;
        private Button withdrawMoneyButton;
        private Button insertMoneyButton;
        private Label welcomelabel;
        private Button backButton;
    }
}