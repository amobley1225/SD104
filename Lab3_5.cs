using System;

namespace Lab_3_5_Amobley
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string blackListWord ="won" ;
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("This is a Spam Message!!");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("Message Approved");
            }
 
        }
    }
}
