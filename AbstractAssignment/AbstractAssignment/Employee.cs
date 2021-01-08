using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssignment
{
    public class Employee : Person, IQuittable
    {
        public int ID { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name:{0} {1}", FirstName, LastName);
            Console.WriteLine("ID:{0}", ID);
        }

        public void Quit(Employee person)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.ID == emp2.ID;
        }
    }
}
 