using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndInheritance
{
    class RetailSalesman : ISalesman, IDevelop
    {
        private string FirstName;
        private string LastName;
        public RetailSalesman(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }
        public void Sell()
        {
            Console.WriteLine("Hello my name is: " + FirstName + " " + LastName + ", I recommend you to buy this product.");
        }
        public void SelfDevelop() { }
    }
}
