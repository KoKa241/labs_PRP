using System;

namespace lab3_1
{

    public class Manufacture
    {
        public List<object> machines = new List<object>();

        public void addMachine(Machine machine) 
        {
            machines.Add(machine);
        }

        public void printMachines()
        {
            foreach (var machine in machines)
            {
                Machine m = (Machine)machine;
                Console.WriteLine($"Type: {m.type}, Plan Time: {m.plan_time}, Actual Time: {m.actual_time}");
            }
        }

        public int sumPlanTime()
        {
            int sum = 0;
            foreach (var machine in machines)
            {
                Machine m = (Machine)machine;
                sum += m.plan_time;
            }
            return sum;
        }

        public int sumActualTime()
        {
            int sum = 0;
            foreach (var machine in machines)
            {
                Machine m = (Machine)machine;
                sum += m.actual_time;
            }
            return sum;
        }

    }

    public class Machine
    {
        public string type { get; set; }
        public int plan_time { get; set; }
        public int actual_time { get; set; }

        public double CalculateDeviation()
        {
            return Math.Abs(plan_time - actual_time);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Machine m1 = new Machine() { type = "Z", plan_time = 2, actual_time = 1 };
            Console.WriteLine($"Deviation is {m1.CalculateDeviation()} hour(s)");

            Machine m2 = new Machine() { type = "Z", plan_time = 2, actual_time = 2 };
            Console.WriteLine($"Deviation is {m2.CalculateDeviation()} hour(s)");

            Manufacture man1 = new Manufacture();
            man1.addMachine(m1);
            man1.addMachine(m2);

            man1.printMachines();
              
            Console.WriteLine($"Sum of plan time is {man1.sumPlanTime()} hour(s)");
            Console.WriteLine($"Sum of actual time is {man1.sumActualTime()} hour(s)");
        }
    }
}