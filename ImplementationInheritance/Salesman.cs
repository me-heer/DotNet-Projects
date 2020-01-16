using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndInterface
{
    abstract class Salesman
    {
        private string FirstName;
        private string LastName;

        abstract public void Sell();

        public Salesman(string fName, string lName) {
            FirstName = fName;
            LastName = lName;
        }

        public string GetFirstName() {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
    }
}
