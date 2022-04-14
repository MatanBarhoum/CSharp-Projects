using System;
using System.Collections.Generic;
using System.Text;
using LearningWithMosh.Math;

namespace LearningWithMosh
{
    public class Program
    {
        static void Main(string[] args)
        {
            string UserSelectedOperator;
            int number1;
            int number2;
            Console.WriteLine("Welcome to Calculator v1.0 Alpha");
            Console.WriteLine("");
            Console.Write("Choose an operator (+, -, /, *, %): ");
            UserSelectedOperator = Console.ReadLine();
            Console.Write("Pick a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pick another number: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            if (UserSelectedOperator == "+") { Console.WriteLine(Calculator.Add(number1, number2)); }
            if (UserSelectedOperator == "-") { Console.WriteLine(Calculator.Sub(number1, number2)); }
            if (UserSelectedOperator == "/") { Console.WriteLine(Calculator.divide(number1, number2)); }
            if (UserSelectedOperator == "*") { Console.WriteLine(Calculator.mulitiply(number1, number2)); }
            if (UserSelectedOperator == "%") { Console.WriteLine(Calculator.remainder(number1, number2)); }
            Console.ReadLine();


        }


    }
}
