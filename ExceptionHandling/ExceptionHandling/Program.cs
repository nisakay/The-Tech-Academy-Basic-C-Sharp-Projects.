using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                List<int> numbers = new List<int>();
                numbers.Add(10);
                numbers.Add(40);
                numbers.Add(50);
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine()); ;
                foreach (int number in numbers)
                {
                    int numberThree = number / numberOne;

                    Console.WriteLine(number + " divided by " + numberOne + "  equals:  " + numberThree);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

