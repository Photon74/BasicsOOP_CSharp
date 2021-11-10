// See https://aka.ms/new-console-template for more information
using Figures;

Circle circle = new(new Coordinates(4, 6), Color.Green, true, 10);
var s = circle.Square;

Rectangle rectangle = new (
    new(4, 8), 
    Color.Red, 
    true, 
    13, 31);

Console.ReadLine();