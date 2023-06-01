using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._12
{
    internal class Group: IEnumerable
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Unnamed";
        List<Student> students;
        public Student this[int index]
        {
            get
            {
                return students[index];
            }
        }

        public Group() { }

        public Group(List<Student> students)
        {
            this.students = students;
        }

        public static List<Student> GetDefaultStudents()
        {
            return new List<Student>()
            {
                new Student
                {
                    GroupID = 1,
                    FirstName = "John",
                    LastName = "Miller",
                    BirthDate = new DateTime(1997, 3, 12)
                },
                new Student
                {
                    GroupID = 2,
                    FirstName = "Candice",
                    LastName = "Leman",
                    BirthDate = new DateTime(2006, 7, 22)
                },
                new Student
                {
                    GroupID = 3,
                    FirstName = "Joey",
                    LastName = "Finch",
                    BirthDate = new DateTime(1996, 11, 30)
                },
                new Student
                {
                    GroupID = 2,
                    FirstName = "Nicole",
                    LastName = "Taylor",
                    BirthDate = new DateTime(1996, 5, 10)
                }
            };
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }

        //public void Sort()
        //{
        //    Array.Sort(students);
        //}

        //public void Sort(IComparer comparer)
        //{
        //    Array.Sort(students, comparer);
        //}
    }
}
