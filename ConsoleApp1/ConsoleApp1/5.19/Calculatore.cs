using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._19
{
    public delegate double CalcDelegate(double a, double b);
    public class Calculator
    {
        public string CurrentDate => DateTime.Now.ToLongDateString();
        public int AddInt(int x, int y) => x + y;

        public static void AddVoid(int x, int y) => Console.WriteLine($"{x} + {y} = {x+y}");
    }
}
