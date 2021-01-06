using System;

namespace assignmentMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculus a = new Calculus();
            int x = a.Addition(12);
            double y = a.Addition(12.5);
            int A = a.Addition("2");

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(A);

        }
    }
}
