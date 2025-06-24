using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracs2
{
    class D
    {
        public virtual void display()
        {
            Console.WriteLine("Display D");
        }
    }

    class E : D
    {
        public new void display()
        {
            Console.WriteLine("Display E");
        }
    }

    class A1
    {
        public virtual void display()
        {
            Console.WriteLine("Display A1");
        }
    }

    class B1 : A1
    {
        public new virtual void display()
        {
            Console.WriteLine("Display B1");
        }
    }
    
    class C1 : B1
    {
        public override void display()
        {
            Console.WriteLine("In display C1");
        }
    }

    internal class Inheritance2
    {
/*        public static void Main(string[] args)
        {
            A1 a = new C1();
            a.display();
        }*/
    }



}
