using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFile = "test.txt";
            var destinationFile = "result.txt";

            EmailFinder emailFinder = new();

            emailFinder.Find(sourceFile, destinationFile);
        }
    }
}
