namespace Figures
{
    public abstract class Figure
    {
        private Color _color;
        private bool _isVisible;
        private (int x, int y) _coordinates;

        public Figure(Color color, bool isVisible, (int x, int y) coordinates)
        {
            _color = color;
            _isVisible = isVisible;
            _coordinates = coordinates;
        }

        public void HorizontallyMove() => _coordinates.y = _coordinates.y + 1;
        public void VerticallyMove() => _coordinates.x = _coordinates.x + 1;
        public void ChangeColor(Color color) => _color = color;
        public bool IsVisible() => _isVisible;
        public abstract double Square();

        public override string ToString()
        {
            return $"Цвет: {_color}\n" +
                $"Видимость: {_isVisible}\n" +
                $"Координаты: {_coordinates}";
        }
    }
}
