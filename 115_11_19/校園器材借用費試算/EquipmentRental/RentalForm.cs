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
            totalLabel.Text = "—";
            label3.Text = "—";
            // TODO 1：新增優惠結果標籤後，每次試算也要將它重設為「—」。

            int days;
            if (int.TryParse(daysTextBox.Text, out days))
            {
                // TODO 2：用 if-else 檢查天數是否在 1～7 天內。
                if (days >= 1 && days <= 7)
                {
                    // 天數有效，進行計算
                    int dailyRate = 0;
                    int total = dailyRate * days;
                    string discountMessage = "";
                    // TODO 3：在天數有效的分支內判斷日費及社團優惠。
                    if (days < 3)
                    {
                        total = (int)(total * 1); 
                        discountMessage = "未達折扣門檻。";
                    }
                    // TODO 4：算出應付金額並更新三個結果欄位。
                    dailyRateLabel.Text = dailyRate.ToString();
                    totalLabel.Text = total.ToString();
                    feedbackLabel.Text = discountMessage;
                }
                else
                {
                    feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
                }
                // TODO 3：在天數有效的分支內判斷日費及社團優惠。
                // TODO 4：算出應付金額並更新三個結果欄位。
                // 完成 TODO 2～4 後，用你的程式取代下一行。
                feedbackLabel.Text = "已讀到整數，請完成範圍檢查與試算。";
            }
            else
            {
                feedbackLabel.Text = "請輸入 1 到 7 之間的整數。";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            dailyRateLabel.Text = "—";
            totalLabel.Text = "—";
            label3.Text = "—";

        }
    }
}
