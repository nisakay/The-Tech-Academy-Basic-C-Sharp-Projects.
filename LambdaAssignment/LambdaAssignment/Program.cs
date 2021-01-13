using System;
using System.Collections.Generic;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>

                {
                    new Employee { FirstName = "Joe", LastName = "Swanson", ID = 1},
                    new Employee { FirstName = "John", LastName = "Robertson", ID = 2 },
                    new Employee { FirstName = "Joe", LastName = "Holladay", ID = 3},
                    new Employee { FirstName = "Mike", LastName = "Johnson", ID = 4},
                    new Employee { FirstName = "Chris", LastName = "Lamarcus", ID = 5},
                    new Employee { FirstName = "Tom", LastName = "Dwight", ID = 6},
                    new Employee { FirstName = "Liam", LastName = "Brown", ID = 7},
                    new Employee { FirstName = "Caleb", LastName = "Kim", ID = 8},
                    new Employee { FirstName = "Steve", LastName = "Danscott", ID = 9},
                    new Employee { FirstName = "Nolan", LastName = "McDonald", ID = 10}
                };

                foreach (Employee Employee in FirstName)
                {
                    Func<Employee, bool> Employee = s => s.FirstName == "Joe";
                    {
                        Console.WriteLine(Employee);
                    }
                }
                


        }
    }
}
