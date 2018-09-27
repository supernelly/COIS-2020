using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Jimy_Nelson
{
    public static class Driver
    {
        public static void Main()
        {
            try
            {
                //For testing class while developing code
                Term t1 = new Term(4, 2); //Creates 4x^2
                Console.WriteLine(t1.Evaluate(2)); // 4(2)^2
            }
            catch (ArgumentException e)
            { Console.WriteLine(e.Message); }

            Console.ReadKey();
        }
    }
}
