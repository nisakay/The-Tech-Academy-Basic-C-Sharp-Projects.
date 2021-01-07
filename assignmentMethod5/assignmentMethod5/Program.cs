using System;

namespace assignmentMethod5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int x = Convert.ToInt32(Console.ReadLine());

            Calculus n = new Calculus();
           
            n.Addition(x);

            //Out parameters
            int a = 50;

            Console.WriteLine("Before method call, value of a : {0}", a);

            n.Addition(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }
    }
}
