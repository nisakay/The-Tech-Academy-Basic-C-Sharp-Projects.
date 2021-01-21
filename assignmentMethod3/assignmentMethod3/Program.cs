using System;

namespace assignmentMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());





            TwoIntegers myMath = new TwoIntegers();

            int result = myMath.Addition(x);

            Console.WriteLine(result);



        }
    }
}
