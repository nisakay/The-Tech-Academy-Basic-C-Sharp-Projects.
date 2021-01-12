using System;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Week day = new Week();

            foreach(string day in day)
                try
                {
                        Console.WriteLine("enter the current day of the week.", day);
                        Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week." , day);
                }
       
        }
    }
}
