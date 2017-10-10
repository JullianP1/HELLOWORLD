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

            Console.WriteLine ("Select an option.\n1.-add\n2.-Subtract\n3.-Multiply\n4.-Divide");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine (AddTwoNumbers(number1, number1));
        }
        public static float AddTwoNumbers(float n1, float n2) 
        {
            float result = n1 + n2;
            return result;
        }
    }
}