using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rectangle : Point
    {
        private double SideA{ get; set; }
        private double SideB { get; set; }
        public Rectangle(Coordinates coordinates, Color color, bool visibility, double a, double b) 
            : base(coordinates, color, visibility)
        {
            SideA = a;
            SideB = b;
        }
    }
}
