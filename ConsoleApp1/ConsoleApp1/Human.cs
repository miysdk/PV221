using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Human
    {
        public int Id { get; set; } = new Random().Next(1000, 10000);
        public string FirstName { get; set; } = "Unassigned";
        public string LastName { get; set; } = "Unassigned";
        public DateTime BirthDate { get; set; }

        public Human() { }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Human(string firstName, string lastName, DateTime birthDate)
            :this(firstName, lastName)
        {
            BirthDate = birthDate;
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        //public abstract void Think();

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                $"First Name: {FirstName}\n" +
                $"Last Name: {LastName}\n" +
                $"Birth Date: {BirthDate.ToShortDateString()}";
        }
    }
}
