using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._12
{
    public class People : IPeople
    {
        List<IPerson> people;
        public int Count
        {
            get
            {
                return people.Count;
            }
        }
        public IPerson this[int index] { 
            get
            {
                if(index >= 0 && index < people.Count)
                {
                    return people[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < people.Count)
                {
                    people[index] = value;
                }
                else throw new IndexOutOfRangeException();
            } 
        }

        public People()
        {
            people = new List<IPerson>();
        }

        public People(List<IPerson> people)
        {
            this.people = people;
        }
    }
}
