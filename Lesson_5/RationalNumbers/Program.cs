namespace RationalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rationals rational1 = new(1, 3);
            Rationals rational2 = new(1, 2);
            Rationals rational3 = rational1 / rational2;

            System.Console.WriteLine(rational3);
        }
    }
}
