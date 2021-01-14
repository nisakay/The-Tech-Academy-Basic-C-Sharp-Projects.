using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            DateTime newTime = DateTime.Now.AddHours(number);

            Console.WriteLine(newTime);
        }
    }
}
