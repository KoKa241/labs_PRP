using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(x1_textbox.Text);
            Console.WriteLine(x1);
            double x2 = double.Parse(x2_textbox.Text);
            Console.WriteLine(x2);
            avarage_textbox.Text = ((x1 + x2) / 2).ToString();
            double result = Math.Cos(x1 * (x2 / (x1 + 53 * Math.Pow(x2, 2))));
            string formattedString = String.Format("{0:0.0000}", result);
            result_textbox.Text = formattedString;

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            x1_textbox.Text = string.Empty;
            x2_textbox.Text = string.Empty;
            result_textbox.Text = string.Empty;
        }
    }
}
