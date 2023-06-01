using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Learner
    {
        public string Group { get; set; } = "Unassigned";
        int[] Marks = new int[0];

        public Student(string firstName, string lastName)
            : base(firstName, lastName) { }

        public Student(string firstName, string lastName, DateTime birthDate)
            : base(firstName, lastName, birthDate) { }

        public Student(string firstName, string lastName, DateTime birthDate, string group)
            :base(firstName, lastName, birthDate)
        {
            Group = group;
        }

        public Student(string firstName, string lastName, DateTime birthDate, string group, int[] marks)
            :this(firstName, lastName, birthDate, group)
        {
            Marks = marks;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Group: {Group}");
        }

        public static int GetMark()
        {
            return new Random().Next(1, 13);
        }

        public static int[] GetMark(int amount)
        {
            if (amount <= 0) return new int[0];
            int[] result = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                result[i] = new Random().Next(1, 13);
            }
            return result;
        }

        public void FillMarks(int amount = 5)
        {
            Marks = GetMark(amount);
        }
        public void FillMarks(int[] marks)
        {
            Marks = marks;
        }
        public int[] GetMarks()
        {
            return Marks;
        }

        public override void Study()
        {
            Console.WriteLine("Student is studying");
        }

        //public override void Think()
        //{
        //    Console.WriteLine("Student is thinking");
        //}
    }
}
