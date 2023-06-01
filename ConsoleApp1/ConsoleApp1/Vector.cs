using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector()
        {
            X = 0;
            Y = 0;
        }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Vector(Point start, Point end)
        {
            X = end.X - start.X;
            Y = end.Y - start.Y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X + v2.X, Y = v1.Y + v2.Y };
        }

        public static Vector operator +(Vector v, int n)
        {
            return new Vector { X = v.X + n, Y = v.Y + n };
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector { X = v1.X - v2.X, Y = v1.Y - v2.Y };
        }

        public static Vector operator -(Vector v, int n)
        {
            return new Vector { X = v.X - n, Y = v.Y - n };
        }

        public static Vector operator *(Vector v, int n)
        {
            return new Vector
            {
                X = v.X * n,
                Y = v.Y * n
            };
        }

        public static Vector operator *(int n, Vector v)
        {
            return v * n;
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        public static bool operator >(Vector v1, Vector v2)
        {
            return Math.Sqrt(v1.X * v1.X + v1.Y * v1.Y) > Math.Sqrt(v2.X * v2.X + v2.Y * v2.Y);
        }

        public static bool operator <(Vector v1, Vector v2)
        {
            return v2 > v1;
        }

        public static bool operator >=(Vector v1, Vector v2)
        {
            return (v1 > v2 || v1 == v2);
        }

        public static bool operator <=(Vector v1, Vector v2)
        {
            return (v1 < v2 || v1 == v2);
        }

        public static bool operator true(Vector v)
        {
            return v.X != 0 || v.Y != 0 ? true : false;
        }

        public static bool operator false(Vector v)
        {
            return v.X == 0 && v.Y == 0 ? true : false;
        }

        //|
        public static Vector operator |(Vector v1, Vector v2)
        {
            if ((v1.X != 0 || v1.Y != 0) || (v2.X != 0 || v2.Y != 0))
                return v2;
            return new Vector();
        }

        //&
        public static Vector operator &(Vector v1, Vector v2)
        {
            if ((v1.X != 0 && v1.Y != 0) && (v2.X != 0 && v2.Y != 0))
                return v2;
            return new Vector();
        }

        public override string ToString()
        {
            return $"Vector({X}, {Y})";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return ToString() == obj.ToString();
        }

        public Vector Clone()
        {
            return (Vector)this.MemberwiseClone();
        }

        public static implicit operator Vector (Point p)
        {
            return new Vector(p.X - 5, p.Y - 5);
        }
    }
}
