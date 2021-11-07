using System;

namespace RationalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rational rational1 = new(47, 34);
            Rational rational2 = new(34, 86);

            Console.WriteLine(rational1);
            Console.WriteLine(rational2);
            Console.WriteLine();
            Console.WriteLine($"{rational1} + {rational2} = {rational1 + rational2}");
            Console.WriteLine($"{rational1} - {rational2} = {rational1 - rational2}");
            Console.WriteLine($"{rational1} * {rational2} = {rational1 * rational2}");
            Console.WriteLine($"{rational1} / {rational2} = {rational1 / rational2}");
            Console.WriteLine($"{rational1} % {rational2} = {rational1 % rational2}");
            Console.WriteLine();
            Console.WriteLine(rational1 + ".ToInt = " + (int)(rational1));
            Console.WriteLine(rational1 + ".ToFloat = " + (float)(rational1));
            Console.WriteLine();
            Console.WriteLine(rational1 != rational2);
            Console.WriteLine(rational1 == rational2);
            Console.WriteLine(rational1 > rational2);
            Console.WriteLine(rational1 < rational2);
            Console.WriteLine(rational1 >= rational2);
            Console.WriteLine(rational1 <= rational2);
        }
    }
}
