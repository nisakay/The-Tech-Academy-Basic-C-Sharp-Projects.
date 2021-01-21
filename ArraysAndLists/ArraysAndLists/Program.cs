using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {


        //Create a one-dimensional Array of strings
        string[] nameArray = new string[] { "Isaac", "Chris", "Marc" };
            string index = Console.ReadLine();
            Console.WriteLine("Select a name "+nameArray[index]);

        //Create a one-dimensional Array of integer
        int[] numArray = new int[] {2,8,60,87,23,103};
        int index = Console.ReadLine();
        Console.WriteLine("Select a number " + numArray[index]);

        List<string> intList = new List<string>();
        intList.Add("I'm a software developer");
        intList.Add("lebron James");
        intList.Remove("Michael Jordan);
        Console.WriteLine("Select a sentence "+intList[0]);
        Console.ReadLine();



    }
}
