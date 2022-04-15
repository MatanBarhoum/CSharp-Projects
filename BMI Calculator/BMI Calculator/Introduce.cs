using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public static class Introduce
    {
       public static void Welcome()
        {
            Console.WriteLine("Hello " + Program.FirstName + " " + Program.LastName + " " + "Your age is " + Program.Age + ", " + "Your weight is " + Program.weight + " " + "and your height is " + Program.height);
            Console.WriteLine("Your result: ");
        }

    }
}
