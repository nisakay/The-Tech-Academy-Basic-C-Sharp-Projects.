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

        public static Person operator == (Person person, ID)
        {
            person.Person.Equals(ID);
            return person;
        }
    }
}
