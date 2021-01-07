using System;

namespace assignmentMethod5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int x = Convert.ToInt32(Console.ReadLine());

            Calculus a = new Calculus();

             a.Addition(x);
        }
    }
}
