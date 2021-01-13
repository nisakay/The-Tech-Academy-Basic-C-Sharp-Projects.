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

            List<string> FirstName = new List<string>()
            {
                "Mike", "Chris","Tom","Joe","Joe","Liam","Caleb","Steve","Nolan","Sam"
            };

            List<string> LastName = new List<string>()
            {
                "Johnson", "Lamarcus","Dwight","Brown","Kim","Danscott","McDonald","Jim","Sim","Pence"
            };

            List<int> ID = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            int i = 0;
            foreach (var firstName in FirstName)
            {
                Employee.Add(new Employee(FirstName, LastName[i], ID[i]));
                i++;
            }

            var numberID = Employee.ID(x => x > 5);

            Console.Write("Squares : ");
            foreach (var firstName in FirstName)
            {
                Console.Write("{0} ", firstName);
            }
            Console.WriteLine();

            person.SayName();
            Console.ReadLine();
        }
    }
}
