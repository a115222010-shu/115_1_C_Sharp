namespace Ending_Balance
{
    partial class Form1
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startingBalancePromptLabel = new System.Windows.Forms.Label();
            this.monthsPromptLabel = new System.Windows.Forms.Label();
            this.startingBalTextBox = new System.Windows.Forms.TextBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.detillListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startingBalancePromptLabel
            // 
            this.startingBalancePromptLabel.AutoSize = true;
            this.startingBalancePromptLabel.Location = new System.Drawing.Point(30, 30);
            this.startingBalancePromptLabel.Name = "startingBalancePromptLabel";
            this.startingBalancePromptLabel.Size = new System.Drawing.Size(200, 46);
            this.startingBalancePromptLabel.TabIndex = 0;
            this.startingBalancePromptLabel.Text = "期初餘額：";
            // 
            // monthsPromptLabel
            // 
            this.monthsPromptLabel.AutoSize = true;
            this.monthsPromptLabel.Location = new System.Drawing.Point(30, 90);
            this.monthsPromptLabel.Name = "monthsPromptLabel";
            this.monthsPromptLabel.Size = new System.Drawing.Size(164, 46);
            this.monthsPromptLabel.TabIndex = 2;
            this.monthsPromptLabel.Text = "月份數：";
            // 
            // startingBalTextBox
            // 
            this.startingBalTextBox.Location = new System.Drawing.Point(220, 25);
            this.startingBalTextBox.Name = "startingBalTextBox";
            this.startingBalTextBox.Size = new System.Drawing.Size(477, 53);
            this.startingBalTextBox.TabIndex = 3;
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(220, 85);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(477, 53);
            this.monthsTextBox.TabIndex = 5;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(41, 392);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(200, 46);
            this.outputDescriptionLabel.TabIndex = 6;
            this.outputDescriptionLabel.Text = "期末餘額：";
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalanceLabel.Location = new System.Drawing.Point(232, 392);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(465, 42);
            this.endingBalanceLabel.TabIndex = 7;
            this.endingBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(74, 474);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(130, 50);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "計算餘額";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(328, 474);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 50);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "清除內容";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(567, 474);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 50);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "離開程式";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // detillListBox
            // 
            this.detillListBox.FormattingEnabled = true;
            this.detillListBox.ItemHeight = 46;
            this.detillListBox.Location = new System.Drawing.Point(40, 148);
            this.detillListBox.Name = "detillListBox";
            this.detillListBox.Size = new System.Drawing.Size(657, 234);
            this.detillListBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 595);
            this.Controls.Add(this.detillListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.startingBalTextBox);
            this.Controls.Add(this.monthsPromptLabel);
            this.Controls.Add(this.startingBalancePromptLabel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "期末餘額計算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingBalancePromptLabel;
        private System.Windows.Forms.Label monthsPromptLabel;
        private System.Windows.Forms.TextBox startingBalTextBox;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox detillListBox;
    }
}