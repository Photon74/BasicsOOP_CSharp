using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    public readonly struct Complex
    {
        private readonly double _a;
        private readonly double _b;

        public Complex(double a, double b)
        {
            this._a = a;
            this._b = b;
        }


    }
}
