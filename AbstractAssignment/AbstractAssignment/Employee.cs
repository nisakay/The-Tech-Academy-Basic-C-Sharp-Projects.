using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssignment
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name:{0} {1}", FirstName, LastName);
        }

        public void Quit(Employee person)
        {
            throw new NotImplementedException();
        }
    }
}
