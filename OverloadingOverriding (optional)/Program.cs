using System;

namespace OverloadingOverriding
{
    class Base {
        public void Print() {
            Console.WriteLine("Base method.");
        }
    }

    class Child : Base {
        public void Print() {
            Console.WriteLine("Child Method.");
        }
    }
    class Add {
        public void Addition()
        {
            Console.WriteLine("Nothing to add.");
        }
        public void Addition(int a, int b)
        {
            Console.WriteLine("Addition of " + a + " and " + b + " is " + (a + b));
        }
        public void Addition(int a, int b, int c)
        {
            Console.WriteLine("Addition of " + a + ", " + b + " and " + c + " is " + (a + b + c));
        }
        public void Addition(int a, int b, double c)
        {
            Console.WriteLine("Addition of " + a + ", " + b + " and " + c + " is " + (a + b + c));
        }
        public void Addition(int a, double b, int c)
        {
            Console.WriteLine("Addition of " + a + ", " + b + " and " + c + " is " + (a + b + c));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Add obj = new Add();
            obj.Addition();
            obj.Addition(1,2);
            obj.Addition(1, 2, 3);
            obj.Addition(1, 2, 3.3);
            obj.Addition(1, 2.2, 3);
        }
    }
}
