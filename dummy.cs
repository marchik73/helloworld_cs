
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Foo
{
  public int MagicNumber = 42;
}

namespace ConsoleApplication1
{
    public class Program
    {
        public static int Add(int op1, int op2)
        {
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

        static void Main(string[] args)
        {
	
        }
    }
}


private String MyValue { get; set; }

// instead of

private String _myValue;

public void DoSomething()
{
   MyValue = "Test";

   // Instead of

   _myValue = "Test";
}

public class Item
{
    private Item _parent;
    private List<Item> _children;

    public void Add(Item child)
    {
        if (child._parent != null)
        {
            throw new Exception("Child already has a parent");
        }
        _children.Add(child);
        child._parent=this;
    }
}



public class Class1{

    public string Prop1{
        get {return m_Prop1;}
        set {m_Prop1 = value; }
    }
    private string m_Prop1; // This is standard private property variable name.

    // How do we cap this variable name? While the compiler can figure out same casing
    // it makes it hard to read.
    private Class2 Class2;

    // We camel case the parameter.
    public Class1(Class2 class2){
      this.Class2 = class2;
    }
}