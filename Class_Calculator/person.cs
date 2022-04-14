using System;

namespace LearningWithMosh
{
    public class person
    {
        public static string name;
        public static byte age;
        
        public static void Welcome()
        {
            Console.WriteLine("Welcome " + name);
            
        }

        public static void personage()
        {
            Console.WriteLine("Your age is " + age);
        }

    }
}
