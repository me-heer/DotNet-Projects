using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> myList = new List<object>() { 1, "Mihir", 67.25};
            List<Object>.Enumerator enumerator = myList.GetEnumerator();
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);
        }
    }
}
