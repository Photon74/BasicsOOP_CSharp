using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Figures
{
    internal class Circle : Point
    {
        double _radius;

        public Circle(Color color, bool isVisible, (int x, int y) coordinates)
            : base(color, isVisible, coordinates) { }

        public override double Square() => Math.Round(Math.PI * _radius * _radius);
    }
}
