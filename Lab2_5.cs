using System;

namespace Lab_2_5_AMobley
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            int result = number1 + number2;
            Console.WriteLine(" Answer Is..");
            Console.WriteLine(result);

            result = number1 - number2;
            Console.WriteLine(" Answer Is..");
            Console.WriteLine(result);

            result = number1 * number2;
            Console.WriteLine(" Answer Is..");
            Console.WriteLine(result);

            double result2 = (double)number1 / (double)number2;
            Console.WriteLine(" Answer Is..");
            Console.WriteLine(result2);

            string username = Console.ReadLine();
            Console.WriteLine("Hello " + username);

            int num1;
            int num2;
            int num3;

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            int result3 = num1 * num2 * num3;
            Console.WriteLine("The Answer is..");
            Console.WriteLine(result3);

            string userAge = Console.ReadLine();
            Console.WriteLine("You look younger than " + userAge + "!");
            




        }
    }
}
