using System;
using System.Collections.Generic;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> person = new Employee<string>();

            person.Things = new List<string>() { "Shoes", "Laptop", "Pen" }; ;

            person.FirstName = "Sample";
            person.LastName = "Student";
            person.SayName();
            Console.ReadLine();
        }
    }
}
