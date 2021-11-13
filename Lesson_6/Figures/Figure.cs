namespace Figures
{
    public abstract class Figure
    {
        public Coordinates Coordinates { get; set; }
        public Color Color { get; set; }
        public bool Visibility { get; set; }

        public Figure(Coordinates coordinates, Color color, bool visibility)
        {
            Coordinates = coordinates;
            Color = color;
            Visibility = visibility;
        }

        //public Figure()
        //{
        //}

        public Coordinates HorizontalMove() => new(Coordinates.X + 1, Coordinates.Y);

        public Coordinates VerticalMove() => new(Coordinates.X, Coordinates.Y + 1);

        public void ChangeColor(Color color) => Color = color;

        public bool IsVisible() => Visibility;
    }
}
