using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                 Console.WriteLine("How old are you");
                int age = Convert.ToInt32(Console.ReadLine());

                int currentYear = 2021;

                int YourAge = currentYear - age;

                if (age <= 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("You were born in {0}", YourAge);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please do not enter zero or negative numbers.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured");
                Console.ReadLine();
                return;
            }
        }
    }
}
