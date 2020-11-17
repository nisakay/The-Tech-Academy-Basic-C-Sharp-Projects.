using System;

namespace booleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Whatis your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Please answer “true” or “false.");
            bool DUI = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have? ");
            int tickets = Convert.ToInt32(Console.ReadLine());

            if (age < 15 && DUI != false && tickets > 3)
            {
                Console.WriteLine("You do not Qualify for Car insurance");
            }
            else
            {
                Console.WriteLine("You Qualify for Car insurance");
            }

            Console.ReadLine();
        }
    }
}
