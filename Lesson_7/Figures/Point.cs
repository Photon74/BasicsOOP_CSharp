namespace Figures
{
    public abstract class Point : Figure
    {
        public Point(Color color, bool isVisible, (int x, int y) coordinates)
            : base(color, isVisible, coordinates) { }

    }
}
