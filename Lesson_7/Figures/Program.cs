// See https://aka.ms/new-console-template for more information
using Figures;

Figure circle = new Circle(Color.Blue, true, (1, 3));
circle.ChangeColor(Color.Navy);
Console.WriteLine($"{nameof(circle)}\n" +
    $"{circle}\n" +
    $"Площадь: {circle.Square()}");
