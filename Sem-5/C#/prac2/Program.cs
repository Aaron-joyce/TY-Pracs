namespace Pracs2
{
    class A
    {
        public virtual void display()
        {
            Console.WriteLine("Display A");
        }
    }

    class B : A
    {
        public override void display()
        {
            Console.WriteLine("Display B");
        }
    }

    class C : B
    {
        public override void display()
        {
            Console.WriteLine("Display C");
        }
    }

    internal class Program:C
    {
        public override void display()
        {
            Console.WriteLine("in program display");
        }
        /*static void Main(string[] args)
        {
            A a = new Program();
            a.display();
        }*/
    }
}