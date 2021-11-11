using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal abstract class Figure
    {
        private Color color;
        private bool isVisible;
        private (int x, int y) coordinates;

        public abstract coordinates HorizontMove(int x, int y);
    }
}
