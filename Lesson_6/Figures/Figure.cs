namespace Figures
{
    internal abstract class Figure
    {
        internal Coordinates Coordinates { get; set; }
        internal Color Color { get; set; }
        internal bool Visibility { get; set; }

        public Figure(Coordinates coordinates, Color color, bool visibility)
        {
            Coordinates = coordinates;
            Color = color;
            Visibility = visibility;
        }

        public Figure()
        {
        }

        public Coordinates HorizontalMove() => new(Coordinates.X + 1, Coordinates.Y);

        public Coordinates VerticalMove() => new(Coordinates.X, Coordinates.Y + 1);

        public void ChangeColor(Color color) => Color = color;

        public bool IsVisible() => Visibility;
    }
}
