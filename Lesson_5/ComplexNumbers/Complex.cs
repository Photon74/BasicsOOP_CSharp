namespace ComplexNumbers
{
    public readonly struct Complex
    {
        private readonly double _a;
        private readonly double _b;

        public Complex(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public static Complex operator +(Complex first, Complex second)
        {
            return new Complex(first._a + second._a, first._b + second._b);
        }

        public static Complex operator -(Complex first, Complex second)
        {
            return new Complex(first._a - second._a, first._b - second._b);
        }

        public static Complex operator *(Complex first, Complex second)
        {
            return new Complex(first._a * second._a - first._b * second._b,
                                first._b * second._a + first._a * second._b);
        }

        public override string ToString()
        {
            return $"{_a}+{_b}i";
        }
    }
}
