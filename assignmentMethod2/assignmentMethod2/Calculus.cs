using System;
using System.Collections.Generic;
using System.Text;

namespace assignmentMethod2
{
    public class Calculus
    {
        public int Addition(int x)
        {
            return x + 5;
        }

        public double Addition(double y)
        {
            return y - 5;
        }

        public int Addition(string z)
        {
            int A = Convert.ToInt32(z);
            return A + 5;
        }
    }
}
