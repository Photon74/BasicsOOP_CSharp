using System;

namespace RationalNumbers
{
    internal class Rational
    {
        private int _numerator;
        private int _denominator;

        public Rational() { }
        public Rational(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public static Rational operator +(Rational first, Rational second)
        {
            int scm = LCM(first._denominator, second._denominator);
            int numerator = first._numerator * (scm / first._denominator) + second._numerator * (scm / second._denominator);
            TryToSimplify(new Rational(numerator, scm), out Rational result);
            return result;
        }

        public static Rational operator -(Rational first, Rational second)
        {
            int scm = LCM(first._denominator, second._denominator);
            int numerator = first._numerator * (scm / first._denominator) - second._numerator * (scm / second._denominator);
            TryToSimplify(new Rational(numerator, scm), out Rational result);
            return result;
        }

        public static Rational operator *(Rational first, Rational second)
        {
            int numerator = first._numerator * second._numerator;
            int denominator = first._denominator * second._denominator;
            TryToSimplify(new Rational(numerator, denominator), out Rational result);
            return result;
        }

        public static Rational operator *(int first, Rational second)
        {
            return new Rational(first, 1) * second;
        }

        public static Rational operator *(Rational first, int second)
        {
            return second * first;
        }

        public static Rational operator /(Rational first, Rational second)
        {
            int numerator = first._numerator * second._denominator;
            int denominator = first._denominator * second._numerator;
            TryToSimplify(new Rational(numerator, denominator), out Rational result);
            return result;
        }

        public static Rational operator ++(Rational rational)
        {
            int numerator = rational._numerator + rational._denominator;
            TryToSimplify(new Rational(numerator, rational._denominator), out Rational result);
            return result;
        }

        public static Rational operator --(Rational rational)
        {
            int numerator = rational._numerator - rational._denominator;
            TryToSimplify(new Rational(numerator, rational._denominator), out Rational result);
            return result;
        }

        public static bool operator ==(Rational first, Rational second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) == second._numerator * (scm / second._denominator);
        }

        public static bool operator !=(Rational first, Rational second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) != second._numerator * (scm / second._denominator);
        }

        public static bool operator >(Rational first, Rational second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) > second._numerator * (scm / second._denominator);
        }

        public static bool operator <(Rational first, Rational second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) < second._numerator * (scm / second._denominator);
        }

        public static bool operator >=(Rational first, Rational second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) >= second._numerator * (scm / second._denominator);
        }

        public static bool operator <=(Rational first, Rational second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) <= second._numerator * (scm / second._denominator);
        }

        public static explicit operator float(Rational r)
        {
            return (float)r._numerator / r._denominator;
        }

        public static explicit operator int(Rational r)
        {
            return r._numerator / r._denominator;
        }

        public static Rational operator %(Rational first, Rational second)
        {
            return first - (int)(first / second) * second;
        }

        public override string ToString()
        {
            if (_numerator == 0) return "0";
            if (_denominator == 1) return $"{_numerator}";
            return $"{_numerator}/{_denominator}";
        }

        /// <summary>
        /// Наименьшее общее кратное двух чисел (Least Common Multiple)
        /// </summary>
        /// <param name="first">первое число</param>
        /// <param name="second">второе число</param>
        /// <returns></returns>
        private static int LCM(int first, int second)
        {
            int max = first > second ? first : second;
            int min = first < second ? first : second;

            if (max % min == 0) return max;

            for (int i = 2; i <= min; i++)
            {
                if (max * i % min == 0) return (max * i);
            }

            return first * second;
        }

        /// <summary>
        /// Наибольший общий делитель двух чисел (Greatest Common Divisor)
        /// </summary>
        /// <param name="first">первое число</param>
        /// <param name="second">второе число</param>
        /// <returns></returns>
        private static int GCD(int first, int second)
        {
            while(first != 0 && second != 0)
            {
                if(first >= second)
                {
                    first %= second;
                }
                else
                {
                    second %= first;
                }
            }
            return first + second;
        }

        // Упрощение дроби
        private static bool TryToSimplify(Rational rational, out Rational result)
        {
            int gcd = GCD(Math.Abs(rational._numerator), rational._denominator);
            result = rational;

            if (rational._numerator == 0) return false;

            result._numerator /= gcd;
            result._denominator /= gcd;
            return true;
        }
    }
}
