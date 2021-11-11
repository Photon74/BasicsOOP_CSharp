using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Point
    {
        private double SideA{ get; set; }
        private double SideB { get; set; }
        public double Square => SideA * SideB;
        public Rectangle(Coordinates coordinates, Color color, bool visibility, double sideA, double sideB) 
            : base(coordinates, color, visibility)
        {
            SideA = sideA;
            SideB = sideB;
        }
    }
}
