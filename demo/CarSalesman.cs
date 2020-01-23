using System;
using System.Collections.Generic;
using System.Text;

namespace prectical3
{
    class CarSalesman : Salesman

    {
        string firstName;
        string lastName;

        public string fullName
        {
            get { return firstName + " " + lastName; }
        }

        public CarSalesman( string firstName,string lastName)
        {
            this.firstName=firstName;
            this.lastName = lastName;
        }
        public void sell()
        { 
            Console.WriteLine("Hello my name is :" + fullName + "thanks for sell car.");
        }
    }
}
