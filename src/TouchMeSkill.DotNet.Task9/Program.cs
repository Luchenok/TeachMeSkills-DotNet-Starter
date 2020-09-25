using System;

namespace TouchMeSkill.DotNet.Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var c = 0;
            Console.Write("Введите число: ");
            bool canPars = int.TryParse(Console.ReadLine(), out c);
            a = c;
            if (canPars) 
            {
                double b = a % 2;
                if (b != 0)
                {
                    Console.WriteLine("Число нечётное!");
                }
                else
                {
                    Console.WriteLine("Число чётное!");
                }
            }
            if (canPars)
            {
                double x = Convert.ToDouble(a) / 2.0;
                if (x != 0)
                {
                    Console.WriteLine("Число нечётное!");
                }
                else
                {
                    Console.WriteLine("Число чётное!");
                }
            }
        }
    }
}
