using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._25
{
    public delegate void ExamDelegate(string str);
    
    public class ExamEventArgs : EventArgs
    {
        public string Task { get; set; }
    }
}
