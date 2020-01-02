using System;

namespace prectical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name, country;
            Console.WriteLine("Enter your name:");
            first_name = Console.ReadLine();
            Console.WriteLine("where are you from?");
            country= Console.ReadLine();
            Console.WriteLine("Hello" + first_name + "from" + country);
                
        }
    }
}
