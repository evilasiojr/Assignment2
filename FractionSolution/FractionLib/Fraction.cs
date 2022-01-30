using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLib
{
    public class Fraction
    {
        public int Top { get; set; }
        public int Bottom { get; set; }

        //constructor
        public Fraction (int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            int newTop;
            int newBottom;

            newTop = (left.Top * right.Bottom) + (left.Bottom * right.Top);
            newBottom = left.Bottom * right.Bottom;

            return new Fraction (newTop, newBottom);

        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            int newTop;
            int newBottom;

            newTop = (left.Top * right.Bottom) - (left.Bottom * right.Top);
            newBottom = left.Bottom * right.Bottom;

            if (newTop < 0)
            {
                throw new Exception("Value is negative");
            }
            else
                return new Fraction(newTop, newBottom);
        }

        public override string ToString()
        {
            return $"{Top}/{Bottom}";
        }



    }
}
