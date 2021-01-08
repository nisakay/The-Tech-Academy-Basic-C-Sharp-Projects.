using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssignment
{
    public class Employee : Person
    {
        public void SayName()
        {
            Console.WriteLine("Name:{0} {1}", FirstName, LastName);
        }
    }
}
