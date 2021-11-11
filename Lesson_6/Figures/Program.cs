// See https://aka.ms/new-console-template for more information
using Figures;

var circle = new Circle(new Coordinates(4, 6), Color.Green, true, 10);
var s = circle.Square;

var rectangle = new Rectangle(
    new Coordinates(4, 8),
    Color.Red,
    true,
    13, 31);
var r = rectangle.Square;

Console.ReadLine();