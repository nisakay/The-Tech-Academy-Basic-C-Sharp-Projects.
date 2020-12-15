using System;
using System.Collections.Generic;

namespace AssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = { "Kobe\t", "MJ\t", "Damian Lillard\t" };

            Console.Write("Add your Nba Player:\n");
            string AddPlayers = Console.ReadLine();
            foreach (string player in players)
            {
                string NewPlayer = player + AddPlayers;
                Console.WriteLine(NewPlayer);
            }
            Console.ReadLine();


            //===============INFINITE LOOP=====================================================//

            //for (int i = 1; i < 3; i--) 
            //{
            //    Console.WriteLine(i + " This is an infinite loop");
            //}


            //===================LOOP COMPARISON========================//
            //int num;

            //num = 1;

            //while (num < 20)

            //{

            //    Console.WriteLine(num);

            //    num++;

            //}

            //int num2;

            //num2 = 1;

            //while (num2 <= 10)

            //{

            //    Console.WriteLine(num2);

            //    num2++;

            //}

            //========================List With Unique Strings==============================

            //List<string> stringList = new List<string>();
            //stringList.Add("Lebron");
            //stringList.Add("MJ");
            //bool isGuessed = false;

            //do
            //{
            //    Console.WriteLine("select your GOAT: ");

            //    string AddPlayers = Console.ReadLine();

            //    if (AddPlayers == "Lebron")
            //    {
            //        Console.WriteLine("You have selected: \t" + stringList[0]);
            //        break;
            //    }

            //    if (AddPlayers == "MJ")
            //    {
            //        Console.WriteLine("You have selected: \t" + stringList[1]);
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("This index does not exist");

            //    }


            //}
            //while (!isGuessed);
            //Console.ReadLine();


            //=====================List With Identical Strings=======================//

            //List<string> stringList = new List<string>();
            //stringList.Add("Apple");
            //stringList.Add("Apple");
            //bool isGuessed = false;

            //do
            //{
            //    Console.WriteLine("select an index of the Array: ");
            //    int fruit = Convert.ToInt32(Console.ReadLine());

            //    if (fruit == 0)
            //    {
            //        Console.WriteLine("You have selected: \t" + stringList[0]);
            //    }
            //    else if (fruit == 1)
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



            //======================================================================================
            //List<string> names = new List<string>() {"Chris","Chris"};
            //List<string> appereance = new List<string>();

            //foreach (string name in names)
            //{
            //    if (name == "Chris")
            //    {
            //        appereance.Add(name);
            //    }
            //}
            //Console.WriteLine(" Chris :"  + appereance.Count);
            //Console.ReadLine();


        }
    }
}
