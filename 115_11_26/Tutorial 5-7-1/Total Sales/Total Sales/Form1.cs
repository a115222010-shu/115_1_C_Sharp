using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try
            {
                StreamReader inputFile;
                decimal total = 0m;
                decimal sales;

                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFile = new StreamReader(openFileDialog1.FileName);

                    while (!inputFile.EndOfStream)
                    {
                        if (decimal.TryParse(inputFile.ReadLine(), out sales))
                        {
                            total += sales;
                        }
                        else
                        {
                            MessageBox.Show("檔案中包含無效的數字。", "檔案錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            inputFile.Close();
                            return;
                        }
                    }
                    inputFile.Close();

                    totalLabel.Text = total.ToString("C");
                }
                else
                {
                    return; // 使用者取消選擇檔案
                }

                

                
            
              
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
