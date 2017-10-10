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

            EvaluateOption (option, number1, number2);
        }
        public static float AddTwoNumbers(float n1, float n2) {
            float result = n1 + n2;
            return result;
        }

		public static float SubtractTwoNumbers(float n1, float n2)
		{
			float result = n1 - n2;
			return result;
		}

		public static float MultiplyTwoNumbers(float n1, float n2)
		{
			float result = n1 * n2;
			return result;
		}

		public static float DivideTwoNumbers(float n1, float n2)
		{
			float result = n1 / n2;
			return result;
		}

        public static void EvaluateOption (int option, float n1, float n2) {
            if(option == 1) {
                Console.WriteLine("Yoyo my fam I added those and got: " + AddTwoNumbers(n1, n2));
            } else if (option == 2) {
                Console.WriteLine("Yoyo my fam I subtracted those and got: " + SubtractTwoNumbers(n1, n2));
			} else if (option == 3) {
				Console.WriteLine("Yoyo my fam I multiplied those and got: " + MultiplyTwoNumbers(n1, n2));
			} else if (option == 4) {
				Console.WriteLine("Yoyo my fam I divided those and got: " + DivideTwoNumbers(n1, n2));
            } else {
                Console.WriteLine("Uhh, pick from the list plz");
            }
		}
    }
}