using System;

namespace TouchMeSkill.DotNet.Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your length of service: ");
            var lengthService = Console.ReadLine();
            var canPars = Double.TryParse(lengthService, out double lengthServiceD);
            if (canPars)
            {
                if (lengthServiceD < 5.0)
                {
                    Console.WriteLine("your bonus is 10% of your salary.");
                }
                if (lengthServiceD >= 5.0 && lengthServiceD < 10)
                {
                    Console.WriteLine("your bonus is 15% of your salary.");
                }
                if (lengthServiceD >= 10.0 && lengthServiceD < 15)
                {
                    Console.WriteLine("your bonus is 25% of your salary.");
                }
                if (lengthServiceD >= 15.0 && lengthServiceD < 20)
                {
                    Console.WriteLine("your bonus is 35% of your salary.");
                }
                if (lengthServiceD >= 20.0 && lengthServiceD < 25)
                {
                    Console.WriteLine("your bonus is 45% of your salary.");
                }
                if (lengthServiceD >= 25.0)
                {
                    Console.WriteLine("your bonus is 50% of your salary.");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }


        }
    }
}
