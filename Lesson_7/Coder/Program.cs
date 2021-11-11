using System.Text;
using Coder;

Console.OutputEncoding = Encoding.UTF8;

const string str = "A";

ICoder coder1 = new ACoder();

Console.WriteLine($"{str} -> {coder1.Encode(str)}"); // "BCD"