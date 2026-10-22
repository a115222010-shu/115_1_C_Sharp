namespace Fuel_Economy
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
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.literTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.kmtlLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.milesPromptLabel.Location = new System.Drawing.Point(84, 31);
            this.milesPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(257, 48);
            this.milesPromptLabel.TabIndex = 0;
            this.milesPromptLabel.Text = "輸入行駛公里";
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gallonsPromptLabel.Location = new System.Drawing.Point(84, 95);
            this.gallonsPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(257, 48);
            this.gallonsPromptLabel.TabIndex = 1;
            this.gallonsPromptLabel.Text = "使用汽油公升";
            // 
            // kmTextBox
            // 
            this.kmTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kmTextBox.Location = new System.Drawing.Point(390, 28);
            this.kmTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(303, 55);
            this.kmTextBox.TabIndex = 2;
            // 
            // literTextBox
            // 
            this.literTextBox.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.literTextBox.Location = new System.Drawing.Point(390, 92);
            this.literTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.literTextBox.Name = "literTextBox";
            this.literTextBox.Size = new System.Drawing.Size(303, 55);
            this.literTextBox.TabIndex = 3;
            this.literTextBox.TextChanged += new System.EventHandler(this.literTextBox_TextChanged);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(84, 157);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(257, 48);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "每公升行駛幾公里";
            // 
            // kmtlLabel
            // 
            this.kmtlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kmtlLabel.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.kmtlLabel.Location = new System.Drawing.Point(390, 157);
            this.kmtlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kmtlLabel.Name = "kmtlLabel";
            this.kmtlLabel.Size = new System.Drawing.Size(303, 48);
            this.kmtlLabel.TabIndex = 5;
            this.kmtlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(184, 259);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(193, 53);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算油耗";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(432, 259);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(154, 53);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 403);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.kmtlLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.literTextBox);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "油耗計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesPromptLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox literTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label kmtlLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

