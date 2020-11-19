using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {


        string[] cars = { "Volvo", "BMW", "Ford" };
        bool isGuessed = false;

        do
        {
            Console.WriteLine("select an index of the Array: ");
            int cars2 = Convert.ToInt32(Console.ReadLine());

            if (cars2 == 0)
            {
                Console.WriteLine("You have selected: \t" + cars[0]);
            }

            if (cars2 == 1)
            {
                Console.WriteLine("You have selected: \t" + cars[1]);
            }

            if (cars2 == 2)
            {
                Console.WriteLine("You have selected: \t" + cars[2]);
            }

            else
            {
                Console.WriteLine("This index does not exist");
            }
        }

        while (!isGuessed);

        Console.ReadLine();

        //==================================Integer Array==================

        //int[] numbers= { 25, 20, 60 };
        //bool isGuessed = false;

        //do
        //{
        //    Console.WriteLine("select an index of the Array: ");
        //    int numbers2 = Convert.ToInt32(Console.ReadLine());

        //    if (numbers2 == 0)
        //    {
        //        Console.WriteLine("You have selected: \t" + numbers[0]);
        //    }

        //    if (numbers2 == 1)
        //    {
        //        Console.WriteLine("You have selected: \t" + numbers[1]);
        //    }

        //    if (numbers2 == 2)
        //    {
        //        Console.WriteLine("You have selected: \t" + numbers[2]);
        //    }

        //    else
        //    {
        //        Console.WriteLine("This index does not exist");
        //    }
        //}

        //while (!isGuessed);

        //Console.ReadLine();
        //==============================LIST ARRAY=====================
        //List<string> stringList = new List<string>();
        //stringList.Add("Lebron");
        //stringList.Add("MJ");
        //bool isGuessed = false;

        //do
        //{
        //    Console.WriteLine("select an index of the Array: ");
        //    int numbers2 = Convert.ToInt32(Console.ReadLine());

        //    if (numbers2 == 0)
        //    {
        //        Console.WriteLine("You have selected: \t" + stringList[0]);
        //    }

        //    if (numbers2 == 1)
        //    {
        //        Console.WriteLine("You have selected: \t" + stringList[1]);
        //    }

        //    else
        //    {
        //        Console.WriteLine("This index does not exist");
        //    }


        //}
        //while (!isGuessed);
        //Console.ReadLine();



    }
}

