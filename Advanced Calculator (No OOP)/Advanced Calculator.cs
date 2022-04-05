using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        public static class Globals
        {
            public static bool is_true = true;
        }
        static void Main(string[] args)
        {
 
            while (Globals.is_true)
            {

                Console.Write("Choose Operator( +, - ): ");
                string op;
                op = Console.ReadLine();

                if (op == "+")
                {
                    addition();
                }


                else if (op == "-")
                {
                    substraction();

                }
                else
                {
                    want_again();
                }
            }
        }

        static double add(double number1, double number2)
        {
            double addition = number1 + number2;
            return addition;
        }

        static double sub(double number1, double number2)
        {
            double subtraction = number1 - number2;
            return subtraction;
        }

        static void substraction()
        {
            
            Console.Write("Enter A number: ");
            Double num1;
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another nubmer: ");
            double num2;
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + " - " + num2 + " = " + sub(num1, num2));
            Console.Write("Do you want to calculate again? y/n ".ToLower());
            string user_picked;
            user_picked = Console.ReadLine();
            if (user_picked == "y")
            {
                Globals.is_true = true;
            }
            else
            {
                Globals.is_true = false;
            }
        }

        static void addition()
        {
            
            Console.Write("Enter A number: ");
            Double num1;
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another nubmer: ");
            double num2;
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + " + " + num2 + " = " + add(num1, num2));
            Console.Write("Do you want to calculate again? y/n ".ToLower());
            string user_picked;
            user_picked = Console.ReadLine();
            if (user_picked == "y")
            {
                Globals.is_true = true;
            }
            else
            {
                Globals.is_true = false;
            }
        }

        static void want_again()
        {
            
            Console.Write("Invalid input. Do you want to return? y/n ".ToLower());
            string user_picked;
            user_picked = Console.ReadLine();
            if (user_picked == "y")
            {
                Globals.is_true = true;
            }
            else
            {
                Globals.is_true = false;
            }
        }



    }


}

