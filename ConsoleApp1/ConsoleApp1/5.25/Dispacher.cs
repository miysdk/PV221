using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._25
{
    public delegate double AnonDelegateDouble(double x, double y);
    public delegate void AnonDelegateInt(int n);
    public delegate void AnonDelegateVoid();
    internal class Dispacher
    {
        public event AnonDelegateDouble eventDouble;
        public event AnonDelegateInt eventVoid;

        public double OnEventDouble(double x, double y)
        {
            if(eventDouble != null)
            {
                return eventDouble(x, y);
            }
            throw new NullReferenceException();
        }

        public void OnEventVoid(int n = 0)
        {
            if(eventVoid != null)
            {
                eventVoid(n);
            }
        }
    }
}
