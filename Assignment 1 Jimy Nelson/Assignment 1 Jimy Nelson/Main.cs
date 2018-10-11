/*
 *  Assignment 1 - Polynomials
 *
 *  Written By: Nelson Su (0616242) and Jimy Nguygens (0618793) - October 2018
 *
 *  Description here
 *  
 *  Usage:
 */
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
            string answerExpo = "", answerCoeff = "", answerCommand = "", answerIndex = "";
            int expo = 0, coeff = 0, index = 0;
            char command = 'o';
            bool letterCheck = true;

            Term t1 = new Term(0, 0);
            Polynomial p1 = new Polynomial();
            Polynomial p2 = new Polynomial();
            Polynomial p3 = new Polynomial();

            // Main do-while loop will call command functions until user quits
            do
            {
                while (letterCheck == true)
                {
                    // Prompt user for a command
                    Console.WriteLine("Command Options");
                    Console.WriteLine("Create a polynomial: 'c' or 'C'");
                    Console.WriteLine("View list of polynomials: 'v' or 'V'");
                    Console.WriteLine("Evaluate a polynomial: 'd' or 'D'");
                    Console.WriteLine("Delete a polynomial: 'd' or 'D'");
                    Console.WriteLine("Add two polynomials: 'a' or 'A'");
                    Console.WriteLine("Multiply two polynomials: 'm' or 'M'");
                    Console.WriteLine("Quit: 'q' or 'Q'");
                    Console.Write("Please enter a command: ");
                    answerCommand = Console.ReadLine();

                    // Check for a char input
                    while (!Char.TryParse(answerCommand, out command))
                    {
                        Console.WriteLine("Please enter an acceptable letter.");
                        Console.WriteLine("Command Options");
                        Console.WriteLine("Create a polynomial: 'c' or 'C'");
                        Console.WriteLine("View list of polynomials: 'v' or 'V'");
                        Console.WriteLine("Evaluate a polynomial: 'e' or 'E'");
                        Console.WriteLine("Delete a polynomial: 'd' or 'D'");
                        Console.WriteLine("Add two polynomials: 'a' or 'A'");
                        Console.WriteLine("Multiply two polynomials: 'm' or 'M'");
                        Console.WriteLine("Quit: 'q' or 'Q'");
                        Console.Write("Please enter a command: ");
                        answerCommand = Console.ReadLine();
                    }

                    command = char.ToUpper(command);
                    switch (command)
                    {
                        case 'C':
                            Console.WriteLine("Create a polynomial");

                            // Input coefficient
                            Console.Write("Enter coefficient: ");
                            answerCoeff = Console.ReadLine();
                            while (!Int32.TryParse(answerCoeff, out coeff))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter coefficient: ");
                                answerCoeff = Console.ReadLine();
                            }
                            t1.Coeff = coeff;

                            // Input exponent
                            Console.Write("Enter exponent: ");
                            answerExpo = Console.ReadLine();
                            while (!Int32.TryParse(answerExpo, out expo))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter fraction 1 denominator: ");
                                answerExpo = Console.ReadLine();
                            }
                            t1.Expo = Convert.ToByte(expo);

                            p1.AddTerm(t1);
                            // Input into list here

                            letterCheck = false;
                            break;

                        case 'V':
                            Console.WriteLine("View list of polynomials");

                            // Print list here

                            letterCheck = false;
                            break;

                        case 'E':
                            Console.WriteLine("Evaluate a polynomial");

                            // Input index number
                            Console.Write("Enter polynomial's index number: ");
                            answerIndex = Console.ReadLine();
                            while (!Int32.TryParse(answerIndex, out index))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                            }
                            // Retrieve polynomial here
                            // Evaluate here

                            letterCheck = false;
                            break;

                        case 'D':
                            Console.WriteLine("Delete a polynomial");

                            // Input index number
                            Console.Write("Enter polynomial's index number: ");
                            answerIndex = Console.ReadLine();
                            while (!Int32.TryParse(answerIndex, out index))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                            }
                            // Delete here

                            letterCheck = false;
                            break;

                        case 'A':
                            Console.WriteLine("Add two polynomials");

                            // Input first index number
                            Console.Write("Enter first polynomial's index number: ");
                            answerIndex = Console.ReadLine();
                            while (!Int32.TryParse(answerIndex, out index))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter first polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                            }
                            // Retrieve first polynomial

                            // Input second index number
                            Console.Write("Enter second polynomial's index number: ");
                            answerIndex = Console.ReadLine();
                            while (!Int32.TryParse(answerIndex, out index))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter second polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                            }
                            // Retrieve second polynomial

                            // Perform addition

                            // Add to list

                            letterCheck = false;
                            break;

                        case 'M':
                            Console.WriteLine("Multiply two polynomials");

                            // Input first index number
                            Console.Write("Enter first polynomial's index number: ");
                            answerIndex = Console.ReadLine();
                            while (!Int32.TryParse(answerIndex, out index))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter first polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                            }
                            // Retrieve first polynomial

                            // Input second index number
                            Console.Write("Enter second polynomial's index number: ");
                            answerIndex = Console.ReadLine();
                            while (!Int32.TryParse(answerIndex, out index))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter second polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                            }
                            // Retrieve second polynomial

                            // Perform multiplication

                            // Add to list

                            letterCheck = false;
                            break;

                        case 'Q': // Quit
                            letterCheck = false;
                            break;

                        default:
                            Console.WriteLine("Please enter an acceptable letter.");
                            answerCommand = "";
                            break;
                    }
                }
                letterCheck = true;
            } while (char.ToUpper(command) != 'Q');

            /*
            try
            {
                // For testing class while developing code pls dont delete until finished assignment
                Polynomial p1 = new Polynomial();
                Polynomial p2 = new Polynomial();
                Polynomial p3 = new Polynomial();

                p1.AddTerm(new Term(2, 2));
                p1.AddTerm(new Term(2, 2));
                p1.AddTerm(new Term(2, 3));

                p2.AddTerm(new Term(1, 2));
                p2.AddTerm(new Term(1, 4));
                p2.AddTerm(new Term(5, 5));

                p1.Print();
                p2.Print();

                Console.WriteLine("Mutiply test");
                p3 = p1 * p2;
                p3.Print();

                Console.WriteLine(p1.Order(p2));
            }
            catch (ArgumentException e)
            { Console.WriteLine(e.Message); }

            Console.ReadKey();
            */
        }
    }
}
