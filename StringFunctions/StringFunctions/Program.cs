using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "Anna said, \"Hello\", Jesse. \n Hello on a new line \t Hello on a tab.";
            //string fileName = @"V:\Users\Jesse";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Issac I love coding");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
