using System;

namespace TouchMeSkill.DotNet.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pi = 3.141592653M;
            decimal r = 2.54M;
            decimal h = 3.0M;

            Console.WriteLine("S = " + (2 * pi * r * (r + h)));
            Console.WriteLine("V = " + (pi * r * r * h));
            Console.ReadLine();
        }
    }
}
