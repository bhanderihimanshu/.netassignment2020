using System;

namespace prectical1
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern();
        }
        static void pattern()
        {
            int i, j;
            for(i=0;i<5;i++)
            {
                 for(j=0;j<5;j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }


    }
}
