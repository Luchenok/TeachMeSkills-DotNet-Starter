using System;
using System.Threading;

namespace TouchMeSkill.DotNet.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var operand1 = 19799;
            var operand2 = 1577;
            Console.WriteLine("Hello World!");


            Console.WriteLine($"Я придумал числа {operand1} и {operand2}");
            GetOperation(operand1, operand2);
        }
         private static void GetOperation(int operand1, int operand2)
        {
           
            
            bool canPars = false;
            do
            {
                Console.Write("Какаое действие мне с ними выполнить: ");
                string sign = Console.ReadLine();
                switch (sign)
                {
                    case "+":
                        {
                            Console.WriteLine("Результат сложения: " + operand1 + operand2);
                            canPars = true;
                        }
                        break;
                    case "-":
                        {
                            Console.WriteLine("Результат вычетания: " + (operand1 - operand2));
                            canPars = true;
                        }
                        break;
                    case "*":
                        {
                            Console.WriteLine("Результат умножения: " + (operand1 * operand2));
                            canPars = true;
                        }
                        break;
                    case "/":
                        {
                            if (operand2 == 0)
                            {
                                Console.WriteLine("На ноль делить нельзя");
                            }
                            else
                            {
                                var total = Convert.ToDecimal(operand1) / Convert.ToDecimal(operand2);
                                Console.WriteLine("Результат деления: " + total);
                                canPars = true;
                            }
                        }
                            break;
                            default:
                        break;
                        }
                } while (canPars == false);
        }
    }
}
