using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._12
{
    public interface IPeople
    {
        int Count { get; }
        IPerson this[int index]
        {
            get;
            set;
        }
    }
}
