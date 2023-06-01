using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rectangle
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A, s.A);
        }

        public override string ToString()
        {
            return $"Rectangle({A}, {B})";
        }
    }
}
