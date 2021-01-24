using System;

namespace assignmentMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second Number");
            int y = Convert.ToInt32(Console.ReadLine());

            TwoIntegers myMath = new TwoIntegers();
            if (y == 0) 
            {
                int result = myMath.Addition(x);

                Console.WriteLine(result);

            }
            else  
            {
                int result = myMath.Addition(x,y);

                Console.WriteLine(result);

            }



        }
    }
}
