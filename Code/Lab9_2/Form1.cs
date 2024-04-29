using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_2
{
    public partial class Form1 : Form
    {
        private double fuel_price = 0;
        private double food_price = 0;
        private double hot_dog_price = 50;
        private double fry_potato_price = 35;
        private double humburger_price = 60;
        private double coca_cola_price = 25;
        private double fuel_price_sum = 0;
        private int time = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "95";
            fuel_price = 55;
            textBox5.Text = fuel_price.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.ReadOnly = false;
            }
            else
            {
                textBox1.ReadOnly = true;
            }
            CalcProduct();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.ReadOnly = false;
            }
            else
            {
                textBox2.ReadOnly = true;
            }
            CalcProduct();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.ReadOnly = false;
            }
            else
            {
                textBox3.ReadOnly = true;
            }
            CalcProduct();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.ReadOnly = false;
            }
            else
            {
                textBox4.ReadOnly = true;
            }
            CalcProduct();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = true;
            textBox6.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox11.Text = hot_dog_price.ToString();
            textBox10.Text = humburger_price.ToString();
            textBox9.Text = fry_potato_price.ToString();
            textBox8.Text = coca_cola_price.ToString();
        }

        private void CalcProduct()
        {
            Double hot_dog_local_price = 0;
            Double local_humburger_price = 0;
            Double local_fry_potato_price = 0;
            Double local_coca_cola_price = 0;
            if (checkBox1.Checked)
            {
                if (textBox1.Text != string.Empty)
                {
                    hot_dog_local_price = hot_dog_price * double.Parse(textBox1.Text);
                }
                
            }
            if (checkBox2.Checked)
            {
                if (textBox2.Text != string.Empty)
                {
                    local_humburger_price = humburger_price * double.Parse(textBox2.Text);
                }
                
            }
            if (checkBox3.Checked)
            {
                if (textBox3.Text != string.Empty)
                {
                    local_fry_potato_price = fry_potato_price * double.Parse(textBox3.Text);
                }
               
            }
            if (checkBox4.Checked)
            {
                if (textBox4.Text != string.Empty)
                {
                    local_coca_cola_price = coca_cola_price * double.Parse(textBox4.Text);
                }
               
            }
            food_price = hot_dog_local_price + local_humburger_price + local_coca_cola_price + local_fry_potato_price;
            label3.Text = food_price.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if(textBox6.Text != string.Empty)
            {
                fuel_price_sum = Double.Parse(textBox6.Text) * fuel_price;
                label4.Text = fuel_price_sum.ToString();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = (food_price + fuel_price_sum).ToString();
            timer1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalcProduct();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CalcProduct();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalcProduct();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CalcProduct();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if(textBox7.Text != String.Empty)
            {
                Double fuel_sum = Double.Parse(textBox7.Text);
                label4.Text = fuel_sum.ToString();
                textBox6.Text = (fuel_sum / fuel_price).ToString();
            }
            else
            {
                label4.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            if (time > 9)
            {
                button2.Visible = true;
                if (time > 19)
                {
                    Console.WriteLine("Працуе");
                    button2.Visible = false;
                    time = 0;
                    timer1.Enabled = false;
                    Application.Restart();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "98")
            {
                fuel_price = 60;
            }
            else if (comboBox1.Text == "95")
            {
                fuel_price = 55;
            }
            else if (comboBox1.Text == "ДП")
            {
                fuel_price = 54.40;
            }
            else if (comboBox1.Text == "Газ")
            {
                fuel_price = 28;
            }
            else if (comboBox1.Text == "95+")
            {
                fuel_price = 56;
            }
            textBox5.Text = fuel_price.ToString();
        }
    }
    }

