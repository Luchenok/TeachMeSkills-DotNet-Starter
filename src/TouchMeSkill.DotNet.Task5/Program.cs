using System;

namespace TouchMeSkill.DotNet.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 7;
            double b = 3;

            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            double c = (a / b);
            Console.WriteLine("a / b = " + c);
            Console.ReadLine();
        }
    }
}
