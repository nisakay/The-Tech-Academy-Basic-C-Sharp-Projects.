using System;

namespace InheritanceAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();
            person.FirstName = "Sample";
            person.LastName = "Student";
            person.SayName();
            Console.ReadLine();
        }
    }
}
