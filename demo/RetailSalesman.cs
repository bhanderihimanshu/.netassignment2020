using System;
using System.Collections.Generic;
using System.Text;

namespace prectical3
{
    class RetailSalesman : Salesman
    {
        public void sell()
        {
            Console.WriteLine("Hello" + this.getName() + "thanks for retial car.");
        }
    }
}
