using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Employee : Human
    {
        public double Salary { get; set; }
        public string Position { get; set; } = "UNASSIGNED";

        public Employee() { }
        public Employee(string firstName, string lastName)
            : base(firstName, lastName) { }
        public Employee(string firstName, string lastName, DateTime birthDate)
            : base(firstName, lastName, birthDate) { }
        public Employee(string firstName, string lastName, DateTime birthDate, double salary)
            : base(firstName, lastName, birthDate)
        {
            Salary = salary;
        }

        //public abstract void EmploymentField();
        //public abstract void Work();

        public override string ToString()
        {
            return base.ToString() + $"\nPosition: {Position}\nSalary: {Salary}";
        }
    }

    //public class Manager : Employee
    //{
    //    public string FieldActivity { get; set; } = "Unassigned";

    //    public Manager(string firstName, string lastName, DateTime birthDate, double salary, string fieldActivity)
    //        :base(firstName, lastName, birthDate, salary)
    //    {
    //        FieldActivity = fieldActivity;
    //    }

    //    public Manager()
    //    {
    //    }

    //    public Manager(string firstName, string lastName) : base(firstName, lastName)
    //    {
    //    }

    //    public Manager(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate)
    //    {
    //    }

    //    public Manager(string firstName, string lastName, DateTime birthDate, double salary) : base(firstName, lastName, birthDate, salary)
    //    {
    //    }

    //    public override void EmploymentField()
    //    {
    //        Console.WriteLine($"Manager. Field activity: {FieldActivity}");
    //    }

    //    public override void Think()
    //    {
    //        Console.WriteLine("Manager is thinking");
    //    }
    //    public override bool Equals(object? obj)
    //    {
    //        if (obj == null) return false;
    //        Manager? other = obj as Manager;
    //        if (other == null) return false;
    //        return other.ToString() == ToString();
    //    }

    //    public override string ToString()
    //    {
    //        return base.ToString() + $"\nManager. Field activity: {FieldActivity}";
    //    }

    //    public override void Work()
    //    {
    //        Console.WriteLine("Managing...");
    //    }
    //}

    //public class Scientist : Employee
    //{
    //    public string ScientificDirection { get; set; } = "Unasigned";

    //    public Scientist(string firstName, string lastName, DateTime birthDate, double salary, string scientificDirection)
    //        : base(firstName, lastName, birthDate, salary)
    //    {
    //        ScientificDirection = scientificDirection;
    //    }

    //    public Scientist()
    //    {
    //    }

    //    public Scientist(string firstName, string lastName) : base(firstName, lastName)
    //    {
    //    }

    //    public Scientist(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate)
    //    {
    //    }

    //    public Scientist(string firstName, string lastName, DateTime birthDate, double salary) : base(firstName, lastName, birthDate, salary)
    //    {
    //    }

    //    public override void EmploymentField()
    //    {
    //        Console.WriteLine($"Scientist. Scientific direction: {ScientificDirection}");
    //    }

    //    public override void Think()
    //    {
    //        Console.WriteLine("Scientist is thinking");
    //    }

    //    public override void Work()
    //    {
    //        Console.WriteLine("Doing science...");
    //    }
    //}

    //public class Specialist : Employee
    //{
    //    public string Qualification { get; set; } = "Unqualified";

    //    public Specialist(string firstName, string lastName, DateTime birthDate, double salary, string qualification)
    //        : base(firstName, lastName, birthDate, salary)
    //    {
    //        Qualification = qualification;
    //    }

    //    public Specialist()
    //    {
    //    }

    //    public Specialist(string firstName, string lastName) : base(firstName, lastName)
    //    {
    //    }

    //    public Specialist(string firstName, string lastName, DateTime birthDate) : base(firstName, lastName, birthDate)
    //    {
    //    }

    //    public Specialist(string firstName, string lastName, DateTime birthDate, double salary) : base(firstName, lastName, birthDate, salary)
    //    {
    //    }

    //    public override void EmploymentField()
    //    {
    //        Console.WriteLine($"Specialist. Qualification: {Qualification}");
    //    }

    //    public override void Think()
    //    {
    //        Console.WriteLine("Specialist is thinking");
    //    }

    //    public override void Work()
    //    {
    //        Console.WriteLine("Specializing...");
    //    }
    //}
}
