using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public static class Admin
    {
        public static int userinput;
        public static bool istrue = true;
        public static void AdminPanel()
        {
            while (istrue)
            {
                Console.WriteLine("-------------------Admin Panel-------------------");
                Console.WriteLine("1. Check money status");
                Console.WriteLine("2. Check milk status");
                Console.WriteLine("3. Check Coffee status");
                Console.WriteLine("4. Return to main menu");
                Console.Write("Enter a number: ");
                userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput == 1) { Console.WriteLine(""); Console.WriteLine("Money: " + Bank.hasmoney); System.Threading.Thread.Sleep(2000); }
                else if (userinput == 2) { Console.WriteLine(""); Console.WriteLine("Remained Milk: " + Bank.hasmilk); System.Threading.Thread.Sleep(2000); }
                else if (userinput == 3) { Console.WriteLine("Remained Coffee: " + Bank.hascoffee); System.Threading.Thread.Sleep(2000); }
                else if (userinput == 4)
                { 
                    Console.Clear();
                    Program.Main();
                }
                else { Console.WriteLine("You entered wrong number, please try again later."); System.Threading.Thread.Sleep(2000); }
            }

        }
    }
}
