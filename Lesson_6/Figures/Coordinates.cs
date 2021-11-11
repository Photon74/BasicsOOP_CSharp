using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public struct Coordinates
    {
        internal int X { get; set; }
        internal int Y { get; set; }

        public Coordinates(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}
