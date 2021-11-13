using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rectangle : Point
    {
        double _sideA;
        double _sideB;

        public Rectangle(Color color, bool isVisible, (int x, int y) coordinates)
            : base(color, isVisible, coordinates)
        {
        }

        public override double Square() => _sideA * _sideB;
    }
}
