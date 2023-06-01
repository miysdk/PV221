using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square
    {
        public double A { get; set; }

        public Square(double a)
        {
            A = a;
        }

        public static explicit operator Square(Rectangle r)
        {
            double shortSide = Math.Min(r.A,r.B);
            double longSide = Math.Max(r.A,r.B);
            if (longSide == shortSide) return new Square(longSide);
            else
            {
                return new Square(shortSide + (longSide - shortSide) / 2);
            }
        }

        public override string ToString()
        {
            return $"Square({A})";
        }
    }
}
