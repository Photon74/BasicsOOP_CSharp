using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal abstract class Figure
    {
        private Color _color;
        private bool _isVisible;
        private (int x, int y) _coordinates;

        protected Figure(Color color, bool isVisible, (int x, int y) coordinates)
        {
            _color = color;
            _isVisible = isVisible;
            _coordinates = coordinates;
        }

        public abstract void HorizontallyMove(int x, int y);
        public abstract void VerticallyMove(int x, int y);
        public abstract void ChangeColor(Color color);
        public abstract bool IsVisible();
    }
}
