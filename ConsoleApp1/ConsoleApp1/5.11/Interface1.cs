using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IResearcher
    {
        void Research();
        void Invent();
    }
    
    public class Researcher : IResearcher
    {
        public void Research()
        {

        }

        public void Invent()
        {

        }
    }
}
