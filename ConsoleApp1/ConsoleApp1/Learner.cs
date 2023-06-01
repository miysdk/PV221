using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Learner : Human
    {
        public string Institution { get; set; } = "Unassigned";

        public Learner(string firstName, string lastName) 
        :base(firstName, lastName) { }

        public Learner(string firstName, string lastName, DateTime birthDate) 
        :base(firstName, lastName, birthDate) { }

        public Learner (string firstName, string lastName, DateTime birthDate, string institution)
            :base(firstName, lastName, birthDate)
        {
            Institution = institution;
        }

        public abstract void Study();
    }
}
