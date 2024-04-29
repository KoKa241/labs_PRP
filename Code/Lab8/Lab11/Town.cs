using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
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

        public Food(string name, string desr, double price)
        {
            Name = name;
            Description = desr;
            Price = price;
        }
        public Food()
        {

        }

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
