using System;

namespace EnumAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Week day = new Week();

                try
                {
                        Console.WriteLine("enter the current day of the week.", day);
                        Week.DaysOfTheWeek answer = (Week.DaysOfTheWeek)Enum.Parse(typeof(Week.DaysOfTheWeek), Console.ReadLine());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week." , day);
                }
       
        }
    }
}
