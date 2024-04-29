using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product some_food = new Food();
            Product some_bread = new Bread();
            Form1 forma = new Form1(some_food, some_bread);
            String result_text;
            if (forma.ShowDialog() == DialogResult.OK)
            {

                if (some_food.Name != null)
                {
                    result_text = $"Name: {some_food.Name}\r\nDescription: {some_food.Description}\r\n" +
                        $"Price: {some_food.Price}\r\n-----------------------------\r\n";
                }
                else
                {
                    result_text = $"Name: {some_bread.Name}\r\nDescription: {some_bread.Description}\r\n" +
                        $"Price: {some_bread.Price}\r\nIs bread: True\r\n-----------------------------\r\n";
                }
                richTextBox1.Text += result_text;
                result_text = "";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
