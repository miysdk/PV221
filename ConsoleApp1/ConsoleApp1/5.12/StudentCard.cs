using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._12
{
    internal class StudentCard
    {
        public int Number { get; set; }
        public string Searies { get; set; } = "Unasigned";
        public override string ToString()
        {
            return $"{Searies}-{Number}";
        }

        public StudentCard()
        {
            Number = new Random().Next(1000, 10000);
            Searies = "ID";
        }
    }
}
