
using System;
using System.Collections.Generic;
using System.Linq; //NOTE: This is needed for the lambda functions.

namespace Drill25Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is my originial Employee List, which includes all of the employees created:");
            EmployeeStack employeeStack = new EmployeeStack();
            foreach (Employee employee in employeeStack.EmployeeList)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            }

            Console.WriteLine("\nThis is a new Employee List with all first names 'Joe':");
            EmployeeStack employeeStack2 = new EmployeeStack();
            foreach (Employee employee in employeeStack2.EmployeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
                }
            }

            Console.WriteLine("\nThis is a new Employee List with all first names 'Joe':");
            List<Employee> employeeStack3 = employeeStack.EmployeeList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee in employeeStack3)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            }

            Console.WriteLine("\nThis is a new Employee List with Id number greater than 5:");
            List<Employee> employeeStack4 = employeeStack.EmployeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in employeeStack4)
            {
                Console.WriteLine("FirstName: {0} LastName: {1} ID: {2}", employee.FirstName, employee.LastName, employee.Id);
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }

    public class EmployeeStack
    {
        public EmployeeStack()
        {
            EmployeeList = new List<Employee>();

            List<string> employeeFirstNames = new List<string>()
            {
                "Isaac", "Chris", "Kevin", "Jordan", "Lebron",
                "Jan", "Joe", "Issa", "Kendra", "Joe"
            };

            List<string> employeeLastNames = new List<string>()
            {
                "Kayoulou", "Brown", "Barlow", "Nnonye", "Blessing",
                "Mac", "Acosta", "Henderson", "Griffin", "Coleman"
            };

            List<int> employeeIds = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                employeeIds.Add(i + 1);
            }

            //NOTE: Since each list has the same amount of elements,'10', and since my goal was to
            //      assign each value in each list with the corresponding object respectively, I just
            //      created an employee in each iteration and assigned that specific employee 
            //      its property by matching indexes to assign values.

            for (int i = 0; i < 10; i++)
            {
                EmployeeList.Add(new Employee());
                EmployeeList[i].FirstName = employeeFirstNames[i];
                EmployeeList[i].LastName = employeeLastNames[i];
                EmployeeList[i].Id = employeeIds[i];
            }
        }
        public List<Employee> EmployeeList { get; set; }
    }
}