internal class Program
{
    private static void Main(string[] args)
    {
        

        DisplayTable();
    }

    static void addNums()
    {
        Console.WriteLine("Enter a number");
        string s1 = Console.ReadLine();
        Console.WriteLine("Enter another number");
        string s2 = Console.ReadLine();
        int a = Convert.ToInt32(s1);
        int b = Convert.ToInt32(s2);
        Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, a + b); 

    }

    static void DisplayTable()
    {
        Console.WriteLine("Enter a number:");
        string s = Console.ReadLine();
        int n = Convert.ToInt32(s);
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0} x {1}: {2}", n, i, n * i);
        }
    }
}