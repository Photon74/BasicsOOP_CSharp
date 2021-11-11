using System.Text;
using Coder;

Console.OutputEncoding = Encoding.UTF8;

const string str = "АБВГДЕЖЗИЙКЛМНОП   абвгдежзийклмноп";

ICoder coder1 = new ACoder();
ICoder coder2 = new BCoder();

var res1 = coder1.Encode(str);
var res2 = coder2.Encode(str);

Console.WriteLine($"{str} -> {res1}");
Console.WriteLine($"{str} -> {res2}");