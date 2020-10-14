using System;

namespace RNG_StatsScreen
{
    class Program
    {
        static void Main(string[] args)
        {

            //Name Input
            Console.WriteLine("Please Insert Your Name");
            Console.WriteLine();
            Console.Beep();
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello there " + name + " let me calculate your stats!");
            Console.WriteLine();

            //Random Calculation
            Random rand = new Random();
            double pi = 3.14;
            int intPi = (int)pi;
            int o = rand.Next(0, 100) + 200;
            int m = rand.Next(0, 100) + o + o;
            int f = rand.Next(0, 100) * o * m;
            int c = rand.Next(5, 10);
            int p = rand.Next(-10, 5);

            //The "Stats Screen"
            Console.WriteLine("Agility : " + (rand.Next(0, 100) + rand.Next(0, 100) + rand.Next(0, 100)));
            Console.WriteLine();
            Console.WriteLine("Stronk : " + (rand.Next(0, 100)));
            Console.WriteLine();
            Console.WriteLine("Smart : " + (o + o + o));
            Console.WriteLine();
            Console.WriteLine("Epicness : " + (f));
            Console.WriteLine();
            Console.WriteLine("Wealth : " + (rand.Next(-100, 100) * m));
            Console.WriteLine();
            Console.WriteLine("Luck : " + (rand.Next(0, 100) + intPi));
            Console.WriteLine();
            Console.Write("Gender : ");
            if (c > p) Console.WriteLine("Male");
            else Console.WriteLine("Female");

            //I just like beep
            Console.Beep();

            //Pause Exit
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter To Exit The Program....");
            string exit = Console.ReadLine();
        }
    }
}
