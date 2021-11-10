using System;

namespace ComplexNumbers
{
    internal class Program
    {
        static void Main()
        {
            Complex complex1 = new Complex(2, 3);
            Complex complex2 = new Complex(3, 4);

            Console.WriteLine(complex1);
            Console.WriteLine(complex2);
            Console.WriteLine();

            Console.WriteLine(complex1 + complex2);
            Console.WriteLine(complex1 - complex2);
            Console.WriteLine(complex1 * complex2);
        }
    }
}
