using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public static class CoffeeMaker
    {
        public static int lattemilk = 25;
        public static int lattecoffee = 5;
        public static int cappucinomilk = 50;
        public static int cappucinocoffee = 15;
        public static int americanocoffee = 10;
        public static void ResourceCheck(int coffee)
        {
            if (coffee == 1 && (Bank.hasmilk < 25 && Bank.hascoffee < 5))
            {
                Console.WriteLine("Insufficient milk or coffee.. try again later.");
                System.Threading.Thread.Sleep(2000);
                Program.Main();
            }

            if (coffee == 2 && (Bank.hasmilk < 50 && Bank.hascoffee < 15))
            {
                Console.WriteLine("Insufficient milk or coffee.. try again later.");
                System.Threading.Thread.Sleep(2000);
                Program.Main();
            }

            if (coffee == 3 && Bank.hascoffee < 10)
            {
                Console.WriteLine("Insufficient coffee.. try again later.");
                System.Threading.Thread.Sleep(2000);
                Program.Main();
            }
        }

        public static void CoffeeGenerator(int coffee)
        {
            if (coffee == 1)
            {
                Bank.hasmilk -= lattemilk;
                Bank.hascoffee -= lattecoffee;
                Console.WriteLine("Making latte");
                ThreeDots();
                Console.WriteLine("Pouring Milk");
                ThreeDots();
                System.Threading.Thread.Sleep(3500);
                Console.WriteLine("Your coffee is ready, please take away the cup with cautious");
                System.Threading.Thread.Sleep(4500);
            }

            if (coffee == 2)
            {
                Bank.hasmilk -= cappucinomilk;
                Bank.hascoffee -= cappucinocoffee;
                Console.WriteLine("Making cappucino"); 
                ThreeDots();
                Console.WriteLine("Pouring Milk"); 
                ThreeDots();
                System.Threading.Thread.Sleep(3500);
                Console.WriteLine("Your coffee is ready, please take away the cup with cautious");
                System.Threading.Thread.Sleep(4500);
            }

            if (coffee == 3)
            {
                Bank.hascoffee -= americanocoffee;
                Console.WriteLine("Making americano"); 
                ThreeDots();
                System.Threading.Thread.Sleep(3500);
                Console.WriteLine("Your coffee is ready, please take away the cup with cautious");
                System.Threading.Thread.Sleep(4500);
            }
        }

        public static void ThreeDots()
        {
            int i;
            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine(".");
                System.Threading.Thread.Sleep(500);
            }
        
        }
    }
}
