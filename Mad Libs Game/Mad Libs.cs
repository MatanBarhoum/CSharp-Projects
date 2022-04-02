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
            string color, pluralNoun, celebrity;

            Console.WriteLine("Welcome to Mad libs game !!");

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a word: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Celebrity you like: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();

        }
    }
}
