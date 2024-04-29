using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class TownEditor : Form
    {
        private Food my_food;
        public TownEditor(Food town)
        {
            my_food = town;
            InitializeComponent();
            textBox1.Text = my_food.Name;
            textBox2.Text = my_food.Description;
            textBox3.Text = my_food.Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            my_food.Name = textBox1.Text;
            my_food.Description = textBox2.Text;
            my_food.Price = double.Parse(textBox3.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
