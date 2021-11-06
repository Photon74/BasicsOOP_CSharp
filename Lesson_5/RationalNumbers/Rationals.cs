using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    internal class Rationals
    {
        private int _numerator;
        private int _denominator;

        public Rationals(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public static Rationals operator +(Rationals first, Rationals second)
        {
            int scm = LCM(first._denominator, second._denominator);
            int numerator = first._numerator * (scm / first._denominator) + second._numerator * (scm / second._denominator);
            return new Rationals(numerator,scm);
        }

        public static Rationals operator -(Rationals first, Rationals second) 
        {
            int scm = LCM(first._denominator, second._denominator);
            int numerator = first._numerator * (scm / first._denominator) - second._numerator * (scm / second._denominator);
            return new Rationals(numerator, scm);
        }

        public static Rationals operator *(Rationals first, Rationals second)
        {
            int numerator = first._numerator * second._numerator;
            int denominator = first._denominator * second._denominator;
            return new Rationals(numerator, denominator);
        }

        public static Rationals operator /(Rationals first, Rationals second)
        {
            int numerator = first._numerator * second._denominator;
            int denominator = first._denominator * second._numerator;
            return new Rationals(numerator, denominator);
        }

        public static Rationals operator ++(Rationals rational)
        {
            int numerator = rational._numerator + rational._denominator;
            return new Rationals(numerator, rational._denominator);
        }

        public static Rationals operator --(Rationals rational)
        {
            int numerator = rational._numerator - rational._denominator;
            return new Rationals(numerator, rational._denominator);
        }

        public static bool operator ==(Rationals first, Rationals second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) == second._numerator * (scm / second._denominator);
        }

        public static bool operator !=(Rationals first, Rationals second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) != second._numerator * (scm / second._denominator);
        }

        public static bool operator >(Rationals first, Rationals second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) > second._numerator * (scm / second._denominator);
        }

        public static bool operator <(Rationals first, Rationals second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) < second._numerator * (scm / second._denominator);
        }

        public static bool operator >=(Rationals first, Rationals second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) >= second._numerator * (scm / second._denominator);
        }

        public static bool operator <=(Rationals first, Rationals second)
        {
            int scm = LCM(first._denominator, second._denominator);
            return first._numerator * (scm / first._denominator) <= second._numerator * (scm / second._denominator);
        }

        public static explicit operator float(Rationals r) => r._numerator / r._denominator;

        public static explicit operator int(Rationals r) => r._numerator / r._denominator;

        public override string ToString()
        {
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

            if(max % min == 0) return max;

            for (int i = 2; i <= min; i++)
            {
                if (max * i % min == 0) return max * i;
            }

            return first * second;
        }

        /// <summary>
        /// Наибольший общий делитель двух чисел (Greatest Common Divisor)
        /// </summary>
        /// <param name="numerator">первое число</param>
        /// <param name="denominator">второе число</param>
        /// <returns></returns>
        private static int GCD(int numerator, int denominator)
        {
            return 1;
        }
    }
}
