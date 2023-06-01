using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5._25
{
    internal class Teacher
    {
        SortedList<int, ExamDelegate> sortedEvents = new SortedList<int, ExamDelegate>();
        public event ExamDelegate examEvent
        {
            add
            {
                while (true)
                {
                    int key = new Random().Next();
                    if (!sortedEvents.ContainsKey(key))
                    {
                        sortedEvents.Add(key, value);
                        break;
                    }
                }
            }
            remove 
            {
                sortedEvents.RemoveAt(sortedEvents.IndexOfValue(value));
            }
        }

        public void Exam(string task)
        {
            foreach (int key in sortedEvents.Keys)
            {
                if (sortedEvents[key] != null)
                {
                    sortedEvents[key](task);
                }
            }
        }
    }
}
