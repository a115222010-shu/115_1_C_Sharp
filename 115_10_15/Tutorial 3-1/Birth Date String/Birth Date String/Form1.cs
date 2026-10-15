using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string output;

            output = dayOfMonthTextBox.Text + ", " + monthTextBox.Text + " " + dayOfWeekTextBox.Text + ", " + yearTextBox.Text;

            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            yearTextBox.Clear();
            dayOfMonthTextBox.Clear();

            dateOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void dateOutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void yearPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void yearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayOfMonthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayOfWeekPromptLabel_Click(object sender, EventArgs e)
        {

        }

        private void dayOfMonthPromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
