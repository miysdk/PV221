using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }

        public static Point operator -(Point p)
        {
            return new Point(-p.X, -p.Y);
        }

        public override string ToString()
        {
            return $"Point({X}; {Y})";
        }


        public static explicit operator Point (Vector v)
        {
            return new Point(v.X + 1, v.Y + 1);
        }
    }
}
