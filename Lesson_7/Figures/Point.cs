using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Point : Figure
    {
        public Point(Color color, bool isVisible, (int x, int y) coordinates)
            : base(color, isVisible, coordinates) { }

        public override void ChangeColor(Color color)
        {
        }

        public override void HorizontallyMove(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override bool IsVisible()
        {
            throw new NotImplementedException();
        }

        public override void VerticallyMove(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
