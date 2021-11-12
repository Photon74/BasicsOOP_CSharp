using Coder;

const string str1 = "Привет, мир!";

ICoder coder1 = new ACoder();
ICoder coder2 = new BCoder();

var res1 = coder1.Encode(str1);
var res1_1 = coder1.Decode(res1);

Console.Write($"{str1} -> {res1}");
Console.WriteLine($" -> {res1_1}");


var res2 = coder2.Encode(str1);
var res2_1 = coder2.Decode(res2);

Console.Write($"{str1} -> {res2}");
Console.WriteLine($" -> {res2_1}");