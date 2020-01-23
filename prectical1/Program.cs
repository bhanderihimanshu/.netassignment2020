using System;

namespace prectical1
{
    class Program
    {
        static void Main(string[] args)
       {
        Pattern1();
        Pattern2();
        Pattern3();
        Pattern4();
        Console.Read();
        }
    static void Pattern1()
    {
        Console.WriteLine("Pattern1");
        int i, j;
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Pattern2()
    {
        Console.WriteLine("Pattern2");
        int i, j;
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Pattern3()
    {
        Console.WriteLine("Pattern3");
        int i, j;
        for (i = 0; i < 5; i++)
        {
            for (j = i; j < 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Pattern4()
    {
        Console.WriteLine("Pattern4");
        int i, j, k;
        for (i = 0; i < 5; i++)
        {
            for (k = 5 - i; k > 1; k--)
            {
                Console.Write(" ");
            }
            for (j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
}

