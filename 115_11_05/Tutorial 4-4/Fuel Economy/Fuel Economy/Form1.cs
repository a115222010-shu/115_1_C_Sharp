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
            double kilometers;
            double liters;
            double kmpl;

            if (double.TryParse(kmTextBox.Text, out kilometers))
            {
                if (double.TryParse(literTextBox.Text, out liters))
                {
                    if (kilometers > 0 && liters > 0)
                    {
                        kmpl = kilometers / liters;
                        kmtlLabel.Text = kmpl.ToString("F2") + "公里/公升";

                    }
                    else
                    {
                        MessageBox.Show("請輸入有效的使用汽油公升數");
                    }

                }
                else
                {
                    MessageBox.Show("請輸入有效的行駛公里數");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void literTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
