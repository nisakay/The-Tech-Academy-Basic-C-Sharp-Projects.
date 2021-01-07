using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentMethod5
{
    public class Calculus
    {
        public void Addition(int x)
        {
            x = x / 2;
            Console.WriteLine(x);
        }

        public void Addition(out int x )
        {
            int temp = 5;
            x = temp;
        }
    }
}
