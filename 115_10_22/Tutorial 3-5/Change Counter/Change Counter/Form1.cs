using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        
        const decimal FIVE_CENTS = 0.05m;
        const decimal TEN_CENTS = 0.10m;
        const decimal TWENTY_FIVE_CENTS = 0.25m;
        const decimal FIFTY_CENTS = 0.50m;
        decimal total = 0.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS;
            totalLabel.Text = total.ToString("C");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS;
            totalLabel.Text = total.ToString("C");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += TWENTY_FIVE_CENTS; 
            totalLabel.Text = total.ToString("C");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS;
            totalLabel.Text = total.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            totalLabel.Text = " ";
            total = 0.00m;
        }
    }
}
