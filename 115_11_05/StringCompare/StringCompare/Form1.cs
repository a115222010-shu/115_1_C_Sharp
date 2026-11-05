using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, System.EventArgs e)
        {
            string String1, string2;

            String1 = txtString1.Text;
            string2 = txtString2.Text;

            if(String.Compare(String1, string2) == 0)
            {
                MessageBox.Show("兩個字串相同");
            }
            else if(String.Compare(String1, string2) < 0)
            {
                MessageBox.Show($"{String1}小於{string2}");
            }
            else
            {
                MessageBox.Show($"{String1}大於{string2}");
            }
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
