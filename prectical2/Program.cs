using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace prectical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name, country;
            while (true)
            {
                Console.WriteLine("Enter your name:");
                first_name = Console.ReadLine();
                Console.WriteLine("where are you from?");
                country = Console.ReadLine();

                if (!(Regex.IsMatch(first_name, @"^[a-z A-Z]+$") && Regex.IsMatch(country, @"^[a-z A-Z]+$")))
                {
                    Console.WriteLine("NOT PROPER FORMAT,ONLY CHARCTOR ARE ALLOWED IS THE FORMAT\n");
                    continue;
                }
                else
                {
                    Console.WriteLine("Hello" + first_name + "from" + country);
                    break;
                }
            }
            Console.Read();
        }
    }
}
