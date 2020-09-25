using System;

namespace TouchMeSkill.DotNet.Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am a 10 word translator about weather. So far, only words are in my stock: sun, wind, rain, snow, hail, cloudy, ice, warm, cold, disgusting.");
            Console.Write("Enter a word for translation into Russian:"); 
            string userWord = Console.ReadLine().ToLower();
            bool IKnow;

            if (userWord == "sun")
            {
                Console.WriteLine("Солнце");
            }
            if (userWord == "wind")
            {
                Console.WriteLine("Ветер");
            }
            if (userWord == "rain")
            {
                Console.WriteLine("Дождь");
            }
            if (userWord == "snow")
            {
                Console.WriteLine("Снег");
            }
            if (userWord == "hail")
            {
                Console.WriteLine("Град");
            }
            if (userWord == "cloudy")
            {
                Console.WriteLine("Облачно");
            }
            if (userWord == "ice")
            {
                Console.WriteLine("Лёд");
            }
            if (userWord == "warm")
            {
                Console.WriteLine("Тёплый");
            }
            if (userWord == "cold")
            {
                Console.WriteLine("Холодный");
            }
            if (userWord == "disgusting")
            {
                Console.WriteLine("Мерзко");
            }
            else
            {
                Console.WriteLine("I don't know such a word yet");
            }
        }
    }
}
