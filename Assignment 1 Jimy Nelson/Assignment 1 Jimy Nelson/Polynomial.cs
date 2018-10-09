using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Jimy_Nelson
{
    public class Term : IComparable
    {
        private double Coefficient;
        private byte Exponent;

        // Creates a term with the given coefficient and exponent
        public Term(double coefficient, byte exponent)
        {
            Coefficient = coefficient;
            Exponent = exponent;
        }

        // Evaluates the current term for a given x
        public double Evaluate(double x)
        {
            double answer;
            answer = Coefficient * Math.Pow(x, Exponent);

            return answer;
        }

        // Returns -1, 0, or 1 if the exponent of the current term
        // is less than, equal to, or greater than the exponent of obj.
        public int CompareTo(Object obj)
        {
            Term t = obj as Term;
            if (t == null)
                return 1;
            else if (Exponent < t.Expo)
                return -1;
            else if (Exponent == t.Expo)
                return 0;
            else
                return 1;
        }

        // Read and write properties for each data member
        public double Coeff
        {
            set
            { Coefficient = value; }
            get
            { return Coefficient; }
        }

        public Byte Expo
        {
            set // 0-255 Range
            {
                if (value > 255)
                    Exponent = 255;
                else if (value < 0)
                    Exponent = 0;
                else
                    Exponent = value;
            }
            get
            { return Exponent; }
        }

        public override string ToString()
        {
            return Coefficient.ToString() + "x^" + Exponent.ToString();
        }
    }

    public class Node<T>
    {
        // Read and write properties for each data member
        public T Item { get; set; }
        public Node<T> Next { get; set; }
        public Node()
        {
            Next = null;
        }
        public Node(T item, Node<T> next)
        {
            Item = item;
            Next = next;
        }
    }
   

    interface IDegree 
    {
        bool Order(Object obj);
       
    }
    public class Polynomial : IDegree
    {
        // A reference to the first node of a singly-linked list
        private Node<Term> Front = new Node<Term>();
        private int count;  // Keeps track of number of terms

        // Creates the polynomial 0
        public Polynomial() 
        { }

        // Inserts the given term "term" into the current polynomial in its proper order
        public void AddTerm(Term t)
        {
            Node<Term> previous = Front;
            Node<Term> current = Front.Next;       
            
            // Sort Exponent
            while (current != null && t.CompareTo(current.Item) < 0)
            {
                previous = current;
                current = current.Next;
            }

            previous.Next = new Node<Term>(t, previous.Next);
            count++;

            // Gather Like Terms
            previous = Front;
            current = Front.Next;
            while (current.Next != null)
            {
                // Still needs to be fixed
                Console.WriteLine(previous.Next.Item.CompareTo(current.Next.Item));
                Term p = previous.Next.Item as Term;
                Term c = current.Next.Item as Term;
                Term temp = new Term(0, 0);
                if (previous.Next.Item.CompareTo(current.Next.Item) == 0)
                {
                    p = previous.Next.Item;
                    c = current.Next.Item;
                    temp.Coeff = p.Coeff + c.Coeff;
                    temp.Expo = p.Expo;

                    previous.Next = new Node<Term>(temp, previous.Next);
                } 
                previous = current;
                current = current.Next;
            }
        }

        // Adds the given polynomials p and q to yield a new polynomial
        public static Polynomial operator+(Polynomial p, Polynomial q)
        {
            Polynomial pq = new Polynomial();

           
            return pq;
        }
        /*
        // Multiplies the given polynomials p and q to yield a new polynomial
        public static Polynomial operator*(T p, T q)
        {
            T pq = new Polynomial();
        }
        // Evaluates the current polynomial for a given x
        public double Evaluate(double x)
        {
            double result;
            result = 0;
            return result;
        }
        */
        // Prints the current polynomial
        public void Print()
        {
            Node<Term> temp = Front.Next;
            while (temp != null)
            {
                Console.Write(temp.Item);
                temp = temp.Next;
                if (temp != null)
                    Console.Write(" + ");
            }
        }

        public bool Order(Object obj)
        {
            //not done yet lol
            return true;
        }
    }
    /*
    public class Polynomials 
    {
        private List<Polynomials> P;

        // Creates an empty list of polynomials
        public Polynomials()
        {
           
            List<Polynomials> polynomials = new List<Polynomials>(P);
            polynomials.Clear();
        }
        
         //Retrieves the polynomial stored at position i-1 in the list
        public Polynomials Retrieve(int i)
        {
            int potato;
            Node<Term> curr = front;
            if (i >= 0 && i <= count - 1)
            {
                for (potato = 0; potato <= count; potato++)
                {
                    curr = curr.Next;
                }
                return curr.Item;
            }
            else
                return default(T);
          }
        // Inserts polynomial p into the list of polynomials ordered by degree
        public void Insert(Polynomials p)
        { }
        // Deletes the polynomial at index i-1
        public void Delete(int i)
        { }
        // Prints out the list of polynomials (beginning with polynomial 1)
        public void Print()
        { }
    }
    */
}

