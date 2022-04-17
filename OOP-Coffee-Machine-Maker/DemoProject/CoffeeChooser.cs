using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class CoffeeChooser
    {
        public static void CoffeePicked()
        {
            if (Program.CoffeeeChoosed == 1) { Console.WriteLine("Please wait while we making your latte, waiting for payment..."); }
            else if (Program.CoffeeeChoosed == 2) { Console.WriteLine("Please wait while we making your cappucino, waiting for payment..."); }
            else if (Program.CoffeeeChoosed == 3) { Console.WriteLine("Please wait while we making your americano, waiting for payment..."); }
            else if (Program.CoffeeeChoosed == 123) { Console.Clear(); Admin.AdminPanel(); }
            else { Console.WriteLine("Error."); }
        }
    }
}
