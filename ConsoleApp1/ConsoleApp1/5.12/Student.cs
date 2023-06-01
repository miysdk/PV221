using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1._5._25;

namespace ConsoleApp1._5._12
{
    internal class Student: IComparable, ICloneable
    {
        public string FirstName { get; set; } = "Unnamed";
        public string LastName { get; set; } = "Undefined";
        public DateTime BirthDate { get; set; }
        public StudentCard Card { get; set; } = new StudentCard();
        public int GroupID { get; set; } = 0;

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.Card = new StudentCard
            {
                Searies = this.Card.Searies,
                Number = this.Card.Number
            };
            return temp;
        }

        public int CompareTo(object? obj)
        {
            return LastName.CompareTo((obj as Student).LastName);
        }

        public override string ToString()
        {
            return $"Student {FirstName} {LastName}\nBirth Date: {BirthDate.ToShortDateString()} ({(DateTime.Now - BirthDate).Days / 365} years)\nStudent card info: {Card}";
        }

        public void Exam(string task)
        {
            Console.WriteLine($"Student {LastName} solved the {task}");
        }
    }
}
