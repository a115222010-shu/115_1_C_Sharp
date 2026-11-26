using System;
using System.Windows.Forms;

namespace EquipmentRental
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            label3.Text = "—";
            totalLabel.Text = "—";
            feedbackLabel.Text = string.Empty;

            if (!int.TryParse(daysTextBox.Text, out int days) || days < 1 || days > 7)
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                return;
            }

            int dailyRate;
            if (days <= 2)
            {
                dailyRate = 80;
            }
            else if (days <= 5)
            {
                dailyRate = 70;
            }
            else
            {
                dailyRate = 60;
            }

            int discount = 0;
            string discountMessage;

            if (clubCheckBox.Checked && days >= 3)
            {
                discount = 30;
                discountMessage = "折抵 30 元";
            }
            else if (clubCheckBox.Checked)
            {
                discountMessage = "未達折抵門檻";
            }
            else
            {
                discountMessage = "無優惠";
            }

            int total = days * dailyRate - discount;

            dailyRateLabel.Text = $"{dailyRate} 元";
            label3.Text = discountMessage;
            totalLabel.Text = $"{total} 元";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            daysTextBox.Clear();
            clubCheckBox.Checked = false;
            dailyRateLabel.Text = "—";
            totalLabel.Text = "—";
            label3.Text = "—";
            feedbackLabel.Text = string.Empty;
            daysTextBox.Focus();
        }
    }
}
