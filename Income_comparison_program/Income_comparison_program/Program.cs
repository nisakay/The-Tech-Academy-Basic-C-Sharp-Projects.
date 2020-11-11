using System;

namespace Income_comparison_program
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string greetings = "Anonymous Income Comparison Program:";
            Console.WriteLine(greetings);
            Console.ReadLine();

            string person1 = "Person 1";
            Console.WriteLine(person1);
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int person1Rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int person1Hours = Convert.ToInt32(Console.ReadLine());

            string person2 = "Person 2";
            Console.WriteLine(person2);
            Console.ReadLine();

            Console.WriteLine("Hourly Rate?");
            int person2Rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            int person2Hours = Convert.ToInt32(Console.ReadLine());

            int weeks1 = 4;
            int month1 = 12;
            double result = person1Rate * person1Hours * weeks1 * month1;
            Console.WriteLine("Annual salary of Person 1 :\n"  + result);
            Console.ReadLine();

            int weeks2 = 4;
            int month2 = 12;
            double result2 = person2Rate * person2Hours * weeks2 * month2;
            Console.WriteLine("Annual salary of Person 2 :\n"  + result2);
            Console.ReadLine();

            bool result3 = result > result2;
            Console.WriteLine("Does Person 1 make more money than Person 2?:\n"  + result3);
            Console.ReadLine();


        }
    }
}
