using System;

namespace HELLOWORLD
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write 2 numbers, I'll prove how good my math skills are.");
            float number1 = float.Parse(Console.ReadLine ());
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine(number1 + number2 + ". I am a literal calculator.");
        }
    }
}