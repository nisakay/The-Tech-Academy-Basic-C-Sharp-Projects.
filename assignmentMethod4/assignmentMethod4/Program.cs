using System;

namespace assignmentMethod4
{
    class Program
    {
        static void Main(string[] args)
        {


            TwoIntegers a = new TwoIntegers();


            int sum = a.Addition(12);
            int num2 = a.Addition(10);

            Console.WriteLine(sum);
            Console.WriteLine(num2);
        }
    }
}
