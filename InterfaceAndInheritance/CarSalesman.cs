using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndInheritance
{
    class CarSalesman : ISalesman
    {
        private string FirstName;
        private string LastName;
        public CarSalesman(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
        public void Sell()
        {
            Console.WriteLine("Hello my name is: " + FirstName + " " + LastName + ", I recommend you to buy this car.");
        }
    }
}
