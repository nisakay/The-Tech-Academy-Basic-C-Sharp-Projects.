using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {


        //Create a one-dimensional Array of strings
        string[] nameArray = new string[] { "Isaac", "Chris", "Marc" };
        Console.WriteLine("Select a name ");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index >= 0 && index <= 2)
        {
            Console.WriteLine(nameArray[index]);
        }
        else
        {
            Console.WriteLine("Sorry, but the number you entered is out of bounds of the array");
        }

        //Create a one - dimensional Array of integer
        int[] numArray2 = new int[] { 2, 8, 60, 87, 23, 103 };
        Console.WriteLine("Select a number ");
        int index2 = Convert.ToInt32(Console.ReadLine());
        if (index2 >= 0 && index2 <= 6)
        {
            Console.WriteLine(numArray2[index2]);
        }
        else
        {
            Console.WriteLine("Sorry, but the number you entered is out of bounds of the array");
        }


        List<string> intList = new List<string>();
        intList.Add("I'm a software developer");
        intList.Add("lebron James");
        intList.Remove("Michael Jordan");
        Console.WriteLine("Select a sentence ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x >= 0 && x <= 1)
        {
            Console.WriteLine(intList[x]);
        }
        else
        {
            Console.WriteLine("Sorry, but the number you entered is out of bounds of the List");
        }
        Console.ReadLine();



    }
}
