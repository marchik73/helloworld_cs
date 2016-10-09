using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Foo
{
  public int MagicNumber = 42;
  private int IllegalOp := 32.
}

namespace HELLO
{
    class PersonInfo
    {
        public string Name { get; private set; }

        public  PersonInfo(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("The name of this person is {0}.", this.Name);
        }

    }
}
