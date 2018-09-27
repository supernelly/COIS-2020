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
            double Base;
            byte exponent;
            do
            {
                try
                {
                    Console.WriteLine("Please enter the real cofficent");
                    Base = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Base = -1;
                }
            } while (Base <= -1);
            Console.WriteLine(Base);
            do
            {
                try
                {
                    Console.WriteLine("Please enter the postive coeficent");
                    exponent = Convert.ToByte(Console.ReadLine());
                    break;
                }
                catch(Exception)
                {
                      
                }
            } while (true);
            Term t1 = new Term(Base, exponent);
            try
            {
                Console.WriteLine(t1.Evaluate(5));
            }
            catch(Exception)
            {

            }

           
            Console.ReadKey();
        }
    }
}
