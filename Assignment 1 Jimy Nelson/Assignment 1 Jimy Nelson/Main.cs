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
                // For testing class while developing code pls dont delete until finished assignment
                Polynomial p1 = new Polynomial();
                Polynomial p2 = new Polynomial();
                Polynomial p3 = new Polynomial();
                Polynomial p4 = new Polynomial();

                p1.AddTerm(new Term(2, 2));
                p1.AddTerm(new Term(2, 2)); // 4x^2
                 
                

                p2.AddTerm(new Term(1, 2));
                p2.AddTerm(new Term(1, 4));
                p2.AddTerm(new Term(5, 5)); // 5x^5 + 1x^4 + 1x^2

                p1.Print();
                p2.Print();
                p3 = p1 + p2;
                p3.Print();

                Console.WriteLine("Mutiply test");
                p4 = p1 * p2;
                p4.Print();

                Console.WriteLine(p2.Evaluate(1)); // 5(1)^5 + 1(1)^4 + 1(1)^2

            }
            catch (ArgumentException e)
            { Console.WriteLine(e.Message); }

            Console.ReadKey();
        }
    }
}
