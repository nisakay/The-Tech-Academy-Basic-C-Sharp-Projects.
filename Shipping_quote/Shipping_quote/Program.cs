using System;

namespace Shipping_quote
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetings = "Welcome to Package Express. Please follow the instructions below.";
            Console.WriteLine(greetings);
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package lenght:");
            int lenght = Convert.ToInt32(Console.ReadLine());

            if (width + lenght + height > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            double total = (height * width * length) * weight / 100;
            Console.WriteLine("Your estimated total for shipping this package is :\n$" + total);
            Console.ReadLine();
        }
    }
}
