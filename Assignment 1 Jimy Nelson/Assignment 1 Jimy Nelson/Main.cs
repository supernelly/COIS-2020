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
            /*
            double coefficient;
            byte exponent;
            do
            {
                try
                {
                    Console.WriteLine("Please enter a real coefficient");
                    coefficient = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    coefficient = -1;
                }
            } while (coefficient <= -1);
            Console.WriteLine(coefficient);
            do
            {
                try
                {
                    Console.WriteLine("Please enter a postive exponent");
                    exponent = Convert.ToByte(Console.ReadLine());
                    break;
                }
                catch (ArgumentException e)
                { Console.WriteLine(e.Message); }
            } while (true);
            Term t1 = new Term(coefficient, exponent);
            try
            {
                Console.WriteLine(t1.Evaluate(5));
            }
            catch (ArgumentException e)
            { Console.WriteLine(e.Message); }
            */

            try
            {
                //  For testing class while developing code pls dont delete until finished assignment
                Polynomial<Term> p1 = new Polynomial<Term>();
                p1.AddTerm(new Term(4, 7));
                p1.AddTerm(new Term(4, 4));
                p1.AddTerm(new Term(4, 3));
                p1.AddTerm(new Term(1, 2));
                p1.AddTerm(new Term(23, 5));
                p1.AddTerm(new Term(69, 1));
                p1.AddTerm(new Term(4, 6));

                p1.Print(); // Viola, sorted by expo, need to finish add/subtract polynomial to sort by coeff too
            }
            catch (ArgumentException e)
            { Console.WriteLine(e.Message); }

            Console.ReadKey();
        }
    }
}
