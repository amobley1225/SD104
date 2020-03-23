using System;

namespace Lab_5_6_amobley
{
    class Program
    {
        public struct Customer
        {
            public string firstName;
            public string lastName;
            public int age;
            public bool membership;
               
        }
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                firstName = "John",
                lastName = "Smith",
                age = 19,
                membership = false

            };

            Customer customer2 = new Customer
            {
                firstName = "Molly",
                lastName = "Jones",
                age = 28,
                membership = false
            };

            Customer customer3 = new Customer
            {
                firstName = "Jason",
                lastName = "Borne",
                age = 35,
                membership = true
            };

            Customer[] allCustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + "  is Denied Access!");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " Welcome!");
                }

                if (allCustomers[i].membership == true)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is a premium member.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is a standard member.");
                }




            }
        }
    }
}
