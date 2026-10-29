namespace Test_Score_Average
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test3promptLabel = new System.Windows.Forms.Label();
            this.test2promptLabel = new System.Windows.Forms.Label();
            this.test1promptLabel = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.outputDescriptionLabel);
            this.testScoreGroupBox.Controls.Add(this.averageLabel);
            this.testScoreGroupBox.Controls.Add(this.test3promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test2promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test1promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test3TextBox);
            this.testScoreGroupBox.Controls.Add(this.test2TextBox);
            this.testScoreGroupBox.Controls.Add(this.test1TextBox);
            this.testScoreGroupBox.Font = this.Font;
            this.testScoreGroupBox.Location = new System.Drawing.Point(52, 47);
            this.testScoreGroupBox.Margin = new System.Windows.Forms.Padding(8);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.testScoreGroupBox.Size = new System.Drawing.Size(599, 434);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "輸入三個測驗成績";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = this.Font;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(53, 342);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(159, 36);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "平均分數";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Font = this.Font;
            this.averageLabel.Location = new System.Drawing.Point(323, 330);
            this.averageLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(242, 61);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.averageLabel.Click += new System.EventHandler(this.averageLabel_Click);
            // 
            // test3promptLabel
            // 
            this.test3promptLabel.AutoSize = true;
            this.test3promptLabel.Font = this.Font;
            this.test3promptLabel.Location = new System.Drawing.Point(53, 250);
            this.test3promptLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.test3promptLabel.Name = "test3promptLabel";
            this.test3promptLabel.Size = new System.Drawing.Size(202, 36);
            this.test3promptLabel.TabIndex = 5;
            this.test3promptLabel.Text = "測驗成績 #3";
            // 
            // test2promptLabel
            // 
            this.test2promptLabel.AutoSize = true;
            this.test2promptLabel.Font = this.Font;
            this.test2promptLabel.Location = new System.Drawing.Point(53, 160);
            this.test2promptLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.test2promptLabel.Name = "test2promptLabel";
            this.test2promptLabel.Size = new System.Drawing.Size(202, 36);
            this.test2promptLabel.TabIndex = 4;
            this.test2promptLabel.Text = "測驗成績 #2";
            this.test2promptLabel.Click += new System.EventHandler(this.test2promptLabel_Click);
            // 
            // test1promptLabel
            // 
            this.test1promptLabel.AutoSize = true;
            this.test1promptLabel.Font = this.Font;
            this.test1promptLabel.Location = new System.Drawing.Point(53, 56);
            this.test1promptLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.test1promptLabel.Name = "test1promptLabel";
            this.test1promptLabel.Size = new System.Drawing.Size(202, 36);
            this.test1promptLabel.TabIndex = 3;
            this.test1promptLabel.Text = "測驗成績 #1";
            // 
            // test3TextBox
            // 
            this.test3TextBox.Font = this.Font;
            this.test3TextBox.Location = new System.Drawing.Point(323, 247);
            this.test3TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(242, 51);
            this.test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Font = this.Font;
            this.test2TextBox.Location = new System.Drawing.Point(323, 157);
            this.test2TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(242, 51);
            this.test2TextBox.TabIndex = 1;
            this.test2TextBox.TextChanged += new System.EventHandler(this.test2TextBox_TextChanged);
            // 
            // test1TextBox
            // 
            this.test1TextBox.Font = this.Font;
            this.test1TextBox.Location = new System.Drawing.Point(323, 53);
            this.test1TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(242, 51);
            this.test1TextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = this.Font;
            this.calculateButton.Location = new System.Drawing.Point(52, 523);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(8);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(212, 62);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "計算平均值";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = this.Font;
            this.clearButton.Location = new System.Drawing.Point(280, 523);
            this.clearButton.Margin = new System.Windows.Forms.Padding(8);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(155, 62);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = this.Font;
            this.exitButton.Location = new System.Drawing.Point(472, 523);
            this.exitButton.Margin = new System.Windows.Forms.Padding(8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(155, 62);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 638);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testScoreGroupBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.Text = "測驗成績平均值";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox testScoreGroupBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label test3promptLabel;
        private System.Windows.Forms.Label test2promptLabel;
        private System.Windows.Forms.Label test1promptLabel;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

