using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pupil : Learner
    {
        public Pupil(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Pupil(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate)
        {
        }

        public Pupil(string firstName, string lastName, DateTime birthDate, string institution) : base(firstName, lastName, birthDate, institution)
        {
        }

        public override void Study()
        {
            Console.WriteLine("Pupil is studying");
        }

        //public override void think()
        //{
        //    console.writeline("pupil is thinking");
        //}
    }
}
