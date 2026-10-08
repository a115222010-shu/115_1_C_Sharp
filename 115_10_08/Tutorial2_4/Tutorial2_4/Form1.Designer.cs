namespace Tutorial2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.finlandPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.germanyPictureBox = new System.Windows.Forms.PictureBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // finlandPictureBox
            // 
            this.finlandPictureBox.Image = global::Tutorial2_4.Properties.Resources.Finland;
            this.finlandPictureBox.Location = new System.Drawing.Point(12, 113);
            this.finlandPictureBox.Name = "finlandPictureBox";
            this.finlandPictureBox.Size = new System.Drawing.Size(220, 124);
            this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandPictureBox.TabIndex = 0;
            this.finlandPictureBox.TabStop = false;
            this.finlandPictureBox.Click += new System.EventHandler(this.finlandPictureBox_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.Image = global::Tutorial2_4.Properties.Resources.France;
            this.francePictureBox.Location = new System.Drawing.Point(290, 113);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(220, 124);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePictureBox.TabIndex = 1;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // germanyPictureBox
            // 
            this.germanyPictureBox.Image = global::Tutorial2_4.Properties.Resources.Germany;
            this.germanyPictureBox.Location = new System.Drawing.Point(568, 113);
            this.germanyPictureBox.Name = "germanyPictureBox";
            this.germanyPictureBox.Size = new System.Drawing.Size(220, 124);
            this.germanyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanyPictureBox.TabIndex = 2;
            this.germanyPictureBox.TabStop = false;
            this.germanyPictureBox.Click += new System.EventHandler(this.germanyPictureBox_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLabel.Font = new System.Drawing.Font("新細明體", 20F);
            this.countryLabel.Location = new System.Drawing.Point(224, 278);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(342, 142);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(103, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "點選一個國旗，告訴你是哪個國家";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.germanyPictureBox);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.finlandPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox finlandPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.PictureBox germanyPictureBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label label1;
    }
}

