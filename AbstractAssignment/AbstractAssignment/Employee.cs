using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssignment
{
    public class Employee<T>: Person ///IQuittable
    {
        public List<T> Things { get; set; }

        public int ID { get; set; }

        public void SayName(string FirstName, string LastName, int ID)
        {
            Console.WriteLine("Name:{0} {1}", FirstName, LastName);
            Console.WriteLine("ID:{0}", ID);
            
            foreach (T thing in Things)
            {
                Console.WriteLine(thing);
            }
        }

        //public void Quit(Employee person)
        //{
        //    throw new NotImplementedException();
        //}

        //public static bool operator ==(Employee emp1, Employee emp2)
        //{
        //    return emp1.ID == emp2.ID;
        //}
    }
}