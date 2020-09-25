using System;

namespace TouchMeSkill.DotNet.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            var canPars = false;
            do
            {
                Console.Write("Введите целое число от 1 до 100: ");
                string a = Console.ReadLine();
                bool canPars2 = int.TryParse(a, out int c);
                b = c;
                if (canPars2 == false)
                {
                    Console.WriteLine("я могу распозновать только целые числа(");
                }
                if (b > 0 && b < 15)
                {
                    Console.WriteLine("числовой промежуток[0 - 14]");
                    canPars = true;
                }
                if (b > 14 && b < 36)
                {
                    Console.WriteLine("числовой промежуток[15 - 35]");
                    canPars = true;
                }
                if (b > 35 && b < 51)
                {
                    Console.WriteLine("числовой промежуток[36 - 50]");
                    canPars = true;
                }
                if (b > 50 && b < 100)
                {
                    Console.WriteLine("числовой промежуток[51 - 100]");
                    canPars = true;
                }
                else
                {
                    Console.WriteLine("Указанное вами число не входит в указанный диапазон.");
                }
            } while (canPars == false);
            
        }
    }
}
