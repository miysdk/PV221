using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._12
{
    public interface IA
    {
        void Show();
    }

    public interface IB
    {
        void Show();
    }

    public interface IC
    {
        void Show();
    }

    public class InheritInterface : IA, IB, IC
    {
        public void Show()
        {
            Console.WriteLine("Showing");
        }
        void IA.Show()
        {
            Console.WriteLine("Showing IA");
        }
        void IB.Show()
        {
            Console.WriteLine("Showing IB");
        }
        void IC.Show()
        {
            Console.WriteLine("Showing IC");
        }
    }
}
