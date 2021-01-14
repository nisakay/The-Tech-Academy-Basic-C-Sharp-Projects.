using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number);
            using (StreamWriter file = new StreamWriter(@"C:\Users\lione\Documents\IO.txt", true))
            {
                file.WriteLine(number);
            }

            


        }
    }

}
