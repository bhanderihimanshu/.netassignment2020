using System;

namespace prectical4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter infix String:");
            string infix =Console.ReadLine();
           
            string postfix;
            Class1.infixtopostfix(infix,out postfix);
            Console.WriteLine(postfix);
            

        }
    }
}
