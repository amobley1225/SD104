using System;

namespace Lab_2_4_AMobleyy
{
    class Program
    {
        static void Main(string[] args)
        {
            int myFirstNumber = 19;

            int mySecondNumber = 244;

            Console.WriteLine(myFirstNumber * mySecondNumber);

            string myText ="Some Text";

            Console.WriteLine(myText + mySecondNumber);

            string moreText = "Goes Here";

            Console.WriteLine(myText + moreText);

            string color1 = "yellow";

            string color2 = "red";

            bool isYellow = true;

            bool isGreen = false;

            Console.WriteLine(color1 + isYellow + color2 + isGreen);

            double numbers;

            numbers = mySecondNumber / myFirstNumber;

            Console.WriteLine(numbers);

            numbers = mySecondNumber / (double) myFirstNumber;

            Console.WriteLine(numbers);

            Console.WriteLine("Breakpoint Here");

            String textToNumbers = "80473";

            int results = 99 * int.Parse (textToNumbers);

            Console.WriteLine(results);

            DateTime rightNow = DateTime.Now;

            Console.WriteLine(rightNow);

               
                
        }
    }
}
