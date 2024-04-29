using System;

namespace lab4_1
{
    sealed class Service(string shop_name)
    {
        private string _shop_name = shop_name;
        private List<Food> _food_list = new List<Food>();

        public void AddFood(Food food)
        {
            _food_list.Add(food);
        }


        public void RemoveFood(Food food)
        {
            _food_list.Remove(food);
            food.MoveToTrashBin();
        }

        public void RemoveAllFoods()
        {
            foreach (var food in _food_list)
            {
                food.MoveToTrashBin();
            }
            _food_list.Clear();
        }


        public void ShowAllFoods()
        {
            foreach (var food in _food_list)
            {
                Console.WriteLine(food.Name);
            }
        }

    }

    abstract class Product
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract double Price { get; set; }

        public abstract void Use();
        public abstract void Prepare();

    }

    class Food : Product
    {
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override double Price { get; set;}

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


    class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service("Marketopt");

            Food smetana = new Food();
            smetana.Name = "Yagotynske";
            Food food = new Food();
            food.Name = "Gingerbred";

            smetana.Use();

            Bread bread = new Bread();
            bread.Name = "Kyivhlib";
            bread.MoveToTrashBin();


            service.AddFood(food);
            service.AddFood(smetana);

            service.ShowAllFoods();
            service.RemoveAllFoods();


        }
    }
}