using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public static class Exchange
    {
        public static double latte = 1;
        public static double cappucino = 2;
        public static double americano = 2.5;

        public static void MissingMoney()
        {
            if (Program.CoffeeeChoosed == 1) {
                while (Program.usermoney < 1)
                {
                    Console.WriteLine("Sorry, not enough money recived.");
                    Console.WriteLine("You're missing " + (latte - Program.usermoney));
                    Console.Write("Enter money: $");
                    Program.usermoney += Convert.ToDouble(Console.ReadLine());

                    if (Program.usermoney >= latte)
                    {
                        Console.WriteLine("Exchange is: " + (Program.usermoney - latte));
                        Bank.hasmoney += 1;
                    }
                } 
            }

            else if (Program.CoffeeeChoosed == 2)
            {
                while (Program.usermoney < 2)
                {
                    Console.WriteLine("Sorry, not enough money recived.");
                    Console.WriteLine("You're missing " + (cappucino - Program.usermoney));
                    Console.Write("Enter money: $");
                    Program.usermoney += Convert.ToDouble(Console.ReadLine());

                    if (Program.usermoney >= cappucino)
                    {
                        Console.WriteLine("Exchange is: " + (Program.usermoney - cappucino));
                        Bank.hasmoney += 2;
                    }

                }
            }

            else if (Program.CoffeeeChoosed == 3)
            {
                while (Program.usermoney < 2.5)
                {
                    Console.WriteLine("Sorry, not enough money recived.");
                    Console.WriteLine("You're missing " + (americano - Program.usermoney));
                    Console.Write("Enter money: $");
                    Program.usermoney += Convert.ToDouble(Console.ReadLine());

                    if (Program.usermoney >= americano)
                    {
                        Console.WriteLine("Exchange is: " + (Program.usermoney - americano));
                        Bank.hasmoney += 2.5;
                    }

                }
            }
        }
        public static void ExchangedMoney(double moneyrecived, int coffee)
        {
            
            if (moneyrecived >= 1 && coffee == 1) {  Console.WriteLine("Your exchange is " + "$" + (moneyrecived - latte)); Bank.hasmoney += 1;  }
            else if (moneyrecived >= 2 && coffee == 2) {  Console.WriteLine("Your exchange is " + "$" + (moneyrecived - cappucino)); Bank.hasmoney += 2; }
            else if (moneyrecived >= 2.5 && coffee == 3) {  Console.WriteLine("Your exchange is " + "$" + (moneyrecived - americano));  Bank.hasmoney += 2.5; }
            else { MissingMoney(); }
        }
    }
}
