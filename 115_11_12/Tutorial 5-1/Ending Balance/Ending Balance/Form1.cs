using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal Balance;
            int Months;
            const decimal Rate = 0.005m; 

            if (decimal.TryParse(startingBalTextBox.Text, out Balance))
            {
                if(int.TryParse(monthsTextBox.Text, out Months))
                {
                    int count = 1;
                    while (count <= Months)
                    {
                        Balance = Balance * (1+Rate);
                        detillListBox.Items.Add($"第 {count} 個月的本利和：{Balance:C2}");
                        count = count+1;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數字。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的數字。");
            }
            endingBalanceLabel.Text = Balance.ToString("C2");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes 和 endingBalanceLabel 控制項的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detillListBox.Items.Clear();

            // 重設焦點。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
