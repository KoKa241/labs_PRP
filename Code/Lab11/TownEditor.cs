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
        private Town my_town;
        public TownEditor(Town town)
        {
            my_town = town;
            InitializeComponent();
            textBox1.Text = my_town.Name;
            textBox2.Text = my_town.Country;
            textBox3.Text = my_town.Region;
            textBox4.Text = my_town.Population.ToString();
            textBox5.Text = my_town.YearIncome.ToString();
            textBox6.Text = my_town.Square.ToString();
            checkBox1.Checked = my_town.HasPort;
            checkBox2.Checked = my_town.HasAirport;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            my_town.Name = textBox1.Text;
            my_town.Country = textBox2.Text;
            my_town.Region = textBox3.Text;
            my_town.Population = int.Parse(textBox4.Text);
            my_town.YearIncome = double.Parse(textBox5.Text);
            my_town.Square = double.Parse(textBox6.Text);
            my_town.HasPort = checkBox1.Checked;
            my_town.HasAirport = checkBox2.Checked;
            DialogResult = DialogResult.OK;
        }
    }
}
