using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetings = "The Tech Academy \nStudent Daily Report:";
            Console.WriteLine(greetings);
            Console.ReadLine();


            string yourName = "What is your name?";
            Console.WriteLine(yourName);
            Console.ReadLine();

            string course = "What course are you on?";
            Console.WriteLine(course);
            Console.ReadLine();

            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Do you need help with anything ? Please answer “true” or “false.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            string experience = "Were there any positive experiences you’d like to share? Please give specifics.";
            Console.WriteLine(experience);
            Console.ReadLine();

            string feedback = "Is there any other feedback you’d like to provide? Please be specific.";
            Console.WriteLine(feedback);
            Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            byte HoursWorked = Convert.ToByte(Console.ReadLine());
        }
    }
}
