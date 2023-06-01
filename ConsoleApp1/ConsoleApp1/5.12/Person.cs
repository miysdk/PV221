using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._12
{
    public class Person : IPerson
    {
        public string Name { get; set; } = "Unnamed";

        public int Age { get; }
        string gender = "Unassigned";

        public string Gender { 
            set {
                if (value == null) gender = "Unassigned";
                else gender = value;
            } 
        }

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Person:\nName: {Name}\nAge: {Age}\nGender: {gender}";
        }
    }
}
