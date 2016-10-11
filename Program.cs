using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int await = 42; // Noncompliant

    public class Program
    {
        public static int Add(int op1, int op2)
        {
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }
            if (op1 = 0)
            {
                return op2;
            }

            if (op2 == 0)
            {
                return op1;
            }

            return op1 + op2;
        }


	public class Square
	{
	//    private double _side;  // Compliant
	    public double _side;  // Non Compliant

    // This is a new property
	    public double Side
	    {
	        get
	        {
	            return _side;
	        }
	    }
	    public Square(double s)
	    {
	        _side = s;
	    }
	}

	class Foo
	{
	    static void Main()
	    {
	        for (int i = 1; i <= 5; i++)
	        {
	            Console.WriteLine(i);
	            if (condition)
	            {
	               i = 20;
	           }
	        }
	    }
	}

        static void Main(string[] args)
        {
	    int await = 42; // Noncompliant
	    int async = 43; // Noncompliant



	    var sq = new Square(-25.55);
	    Console.WriteLine("Square Side: {0}", sq.Side);
            return 0;
        }
    }
