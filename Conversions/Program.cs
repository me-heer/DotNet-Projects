using System;

namespace Conversions
{
    class Program
    {
        public static int BinaryToDecimal(string Binary) {
            int Decimal = 0;
            for(int i = Binary.Length - 1; i >= 0; i--)
            {
                Decimal = Decimal + (int)Math.Pow(2,i);
            }
            Console.WriteLine("Binary: ${ Binary } is converted to Decimal: ${ Decimal }");
            return Decimal;
        }
        static void Main(string[] args)
        {
            BinaryToDecimal("101");
        }
    }
}
