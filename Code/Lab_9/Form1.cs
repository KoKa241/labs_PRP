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

    public partial class Form1 : Form
    {
        private Product some_food;
        private Product bread;
        public Form1(Product food, Product bread_input)
        {
            some_food = food;
            bread = bread_input;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                some_food.Name = textBox1.Text;
                some_food.Description = textBox2.Text;
                some_food.Price = double.Parse(textBox3.Text);
            }
            else
            {
                bread.Name = textBox1.Text;
                bread.Description = textBox2.Text;
                bread.Price = double.Parse(textBox3.Text);
            }
            DialogResult = DialogResult.OK;
        }
    }

    public abstract class Product
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract double Price { get; set; }

        public abstract void Use();
        public abstract void Prepare();

    }



    public class Food : Product
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override double Price { get; set; }

        public override void Use()
        {
            Console.WriteLine($"Ви з'їли {Name}");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Ви приготували {Name}");
        }


        public virtual void MoveToTrashBin()
        {
            Console.WriteLine($"Ви викинули {Name} у смітник");
        }

    }

    class Bread : Food
    {
        public override void Prepare()
        {
            Console.WriteLine("Ви зробили грінку і приготували бутерброд");
        }

        public override void MoveToTrashBin()
        {
            Console.WriteLine("Ви не можете викинути хліб. Хліб - усьому голова");
        }

    }

}
