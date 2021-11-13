using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public abstract class Point : Figure
    {
        public Point(Coordinates coordinates, Color color, bool visibility) 
            : base(coordinates, color, visibility)
        {
        }
    }
}
