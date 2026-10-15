using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 讀取使用者輸入（公里、公升）並計算公里/公升
            double kilometers;
            double liters;

            if (!double.TryParse(milesTextBox.Text, out kilometers))
            {
                MessageBox.Show("請輸入有效的行駛里程（公里）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                milesTextBox.Focus();
                return;
            }

            if (!double.TryParse(gallonsTextBox.Text, out liters))
            {
                MessageBox.Show("請輸入有效的汽油量（公升）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gallonsTextBox.Focus();
                return;
            }

            if (liters == 0)
            {
                MessageBox.Show("汽油量不可為零。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gallonsTextBox.Focus();
                return;
            }

            double kpl = kilometers / liters; // 公里/公升
            mpgLabel.Text = kpl.ToString("N1") + " 公里/公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
