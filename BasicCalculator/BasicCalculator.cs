using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            Double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number: ");
            Double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Summary: " + (num + num1));
            Console.ReadLine();
        }
    }
}
