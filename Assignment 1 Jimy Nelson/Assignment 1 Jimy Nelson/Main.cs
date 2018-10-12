/*
 *  Assignment 1 - Polynomials
 *
 *  Written By: Nelson Su (0616242) and Jimy Nguygens (0618793) - October 2018
 *
 *  This program allows you to create and manipulate polynomials.
 */
using System;

namespace Assignment_1_Jimy_Nelson
{
    public static class Driver
    {
        public static void Main()
        {
            string answerExpo = "", answerCoeff = "", answerCommand = "", answerIndex = "", answerEvaluate = "", answerTerm = "";
            bool letterCheck = true, letterCheck2 = true, numCheck = true, createTerm = true;
            int coeff = 0, index = 0, evaluate = 0;
            char command = 'o', term = 'o';
            byte expo = 0;

            Term t1 = new Term(0, 0);
            Polynomials list = new Polynomials();
            Polynomial p1 = new Polynomial();
            Polynomial p2 = new Polynomial();
            Polynomial p3 = new Polynomial();

            // Main do-while loop will call command functions until user quits
            do
            {
                while (letterCheck == true)
                {
                    // Prompt user for a command
                    Console.WriteLine();
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

                    // Check for a char input
                    while (!Char.TryParse(answerCommand, out command))
                    {
                        Console.WriteLine("Please enter an acceptable letter.");
                        Console.Write("Please enter a command: ");
                        answerCommand = Console.ReadLine();
                    }

                    command = char.ToUpper(command);
                    switch (command)
                    {
                        case 'C':
                            Console.WriteLine("Create a polynomial");
                            while (createTerm == true)
                            {
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
                                while (!Byte.TryParse(answerExpo, out expo))
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    Console.Write("Enter exponent: ");
                                    answerExpo = Console.ReadLine();
                                }
                                t1.Expo = expo;

                                p1.AddTerm(t1);
                                t1 = new Term(0, 0);

                                // More Terms
                                while (letterCheck2 == true)
                                {
                                    Console.WriteLine("Create more terms?");
                                    Console.Write("Enter 'y' or 'Y' for Yes, 'n' or N' for No: ");
                                    answerTerm = Console.ReadLine();
                                    while (!Char.TryParse(answerTerm, out term))
                                    {
                                        Console.WriteLine("Please enter a proper letter.");
                                        Console.Write("Enter 'y' or 'Y' for Yes, 'n' or N' for No: ");
                                        answerTerm = Console.ReadLine();
                                    }
                                    term = char.ToUpper(term);
                                    if (term == 'N')
                                    {
                                        letterCheck2 = false;
                                        createTerm = false;
                                    }
                                    else if (term == 'Y')
                                    {
                                        letterCheck2 = false;
                                        createTerm = true;
                                    }
                                }
                                letterCheck2 = true;
                            }
                            createTerm = true;
                            Console.Write("Polynomial added: ");
                            p1.Print();
                            list.Insert(p1);
                            p1 = new Polynomial();
                            letterCheck = false;
                            break;

                        case 'V':
                            Console.WriteLine("View list of polynomials");

                            list.Print();
                            letterCheck = false;
                            break;

                        case 'E':
                            Console.WriteLine("Evaluate a polynomial");

                            if (list.count == 0)
                            {
                                Console.WriteLine("There is no polynomials in list");
                                break;
                            }

                            // Input number for 'x'
                            Console.Write("Enter number for 'x': ");
                            answerEvaluate = Console.ReadLine();
                            while (!Int32.TryParse(answerEvaluate, out evaluate))
                            {
                                Console.WriteLine("Please enter a proper number.");
                                Console.Write("Enter number for 'x': ");
                                answerEvaluate = Console.ReadLine();
                            }

                            // Input index number
                            while (numCheck == true)
                            {
                                Console.Write("Enter polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                                while (!Int32.TryParse(answerIndex, out index))
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    Console.Write("Enter polynomial's index number: ");
                                    answerIndex = Console.ReadLine();
                                }
                                if (index >= 1 && index <= list.count)
                                    numCheck = false;
                                else
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    answerIndex = "";
                                }
                            }
                            numCheck = true;

                            p1 = list.Retrieve(index);
                            Console.Write("Polynomial: ");
                            p1.Print();
                            Console.WriteLine("x: " + evaluate + ", Result: " + p1.Evaluate(evaluate));
                            p1 = new Polynomial();
                            letterCheck = false;
                            break;

                        case 'D':
                            Console.WriteLine("Delete a polynomial");

                            if (list.count == 0)
                            {
                                Console.WriteLine("There is no polynomials in list");
                                break;
                            }

                            // Input index number
                            while (numCheck == true)
                            {
                                Console.Write("Enter polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                                while (!Int32.TryParse(answerIndex, out index))
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    Console.Write("Enter polynomial's index number: ");
                                    answerIndex = Console.ReadLine();
                                }
                                if (index >= 1 && index <= list.count)
                                    numCheck = false;
                                else
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    answerIndex = "";
                                }
                            }
                            numCheck = true;

                            Console.Write("Polynomial deleted: ");
                            list.Retrieve(index).Print();
                            list.Delete(index);
                            letterCheck = false;
                            break;

                        case 'A':
                            if (list.count == 0)
                            {
                                Console.WriteLine("There is no polynomials in list");
                                break;
                            }

                            Console.WriteLine("Add two polynomials");

                            // Input first index number
                            while (numCheck == true)
                            {
                                Console.Write("Enter first polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                                while (!Int32.TryParse(answerIndex, out index))
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    Console.Write("Enter first polynomial's index number: ");
                                    answerIndex = Console.ReadLine();
                                }
                                if (index >= 1 && index <= list.count)
                                    numCheck = false;
                                else
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    answerIndex = "";
                                }
                            }
                            numCheck = true;
                            p1 = list.Retrieve(index);

                            // Input second index number
                            while (numCheck == true)
                            {
                                Console.Write("Enter second polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                                while (!Int32.TryParse(answerIndex, out index))
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    Console.Write("Enter second polynomial's index number: ");
                                    answerIndex = Console.ReadLine();
                                }
                                if (index >= 1 && index <= list.count)
                                    numCheck = false;
                                else
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    answerIndex = "";
                                }
                            }
                            numCheck = true;
                            p2 = list.Retrieve(index);

                            p3 = p1 + p2;
                            list.Insert(p3);
                            Console.Write("Result: ");
                            p3.Print();
                            letterCheck = false;
                            break;

                        case 'M':
                            if (list.count == 0)
                            {
                                Console.WriteLine("There is no polynomials in list");
                                break;
                            }

                            Console.WriteLine("Multiply two polynomials");

                            // Input first index number
                            while (numCheck == true)
                            {
                                Console.Write("Enter first polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                                while (!Int32.TryParse(answerIndex, out index))
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    Console.Write("Enter first polynomial's index number: ");
                                    answerIndex = Console.ReadLine();
                                }
                                if (index >= 1 && index <= list.count)
                                    numCheck = false;
                                else
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    answerIndex = "";
                                }
                            }
                            numCheck = true;
                            p1 = list.Retrieve(index);

                            // Input second index number
                            while (numCheck == true)
                            {
                                Console.Write("Enter second polynomial's index number: ");
                                answerIndex = Console.ReadLine();
                                while (!Int32.TryParse(answerIndex, out index))
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    Console.Write("Enter second polynomial's index number: ");
                                    answerIndex = Console.ReadLine();
                                }
                                if (index >= 1 && index <= list.count)
                                    numCheck = false;
                                else
                                {
                                    Console.WriteLine("Please enter a proper number.");
                                    answerIndex = "";
                                }
                            }
                            numCheck = true;
                            p2 = list.Retrieve(index);

                            p3 = p1 * p2;
                            list.Insert(p3);
                            Console.Write("Result: ");
                            p3.Print();
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
        }
    }
}