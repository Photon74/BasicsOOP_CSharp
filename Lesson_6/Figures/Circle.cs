using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Point
    {
        private double Radius { get; set; }
        public double Square => Math.Round(Math.PI * Radius * Radius, 2);

        public Circle(Coordinates coordinates, Color color, bool visibility, double radius)
            : base(coordinates, color, visibility)
        {
            Radius = radius;
        }
    }
}
