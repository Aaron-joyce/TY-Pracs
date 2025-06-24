using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracs2
{
    class A2
    {
        public virtual void display()
        {
            Console.WriteLine("Display A");
        }
    }
    class B2:A2
    {
        public override void display()
        {
            Console.WriteLine("Display B");
        }
    }
    class C2 : B2
    {
        public override void display()
        {
            Console.WriteLine("Display C");
        }
    }

    class D2 : C2
    {
        public virtual void display()
        {
            Console.WriteLine("Display D");
        }
    }

    internal class inheritance3
    {
        public static void Main(string[] args)
        {
            A2 a = new D2();
            a.display();
        }
    }
}
