using System;

namespace AssignementMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Numbers myMath = new Numbers();

                int result = myMath.Addition(userInput);
                int result2 = myMath.Multipliy(userInput);
                int result3 = myMath.Division(userInput);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

        }    
    }
}