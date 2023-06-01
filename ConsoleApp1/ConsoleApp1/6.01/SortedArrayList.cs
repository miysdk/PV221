using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._6._01
{
    internal class SortedArrayList : ArrayList
    {
        public void AddSorted(object item)
        {
            int index = BinarySearch(item);
            if(index < 0)
            {
                index = ~index;
            }
            Insert(index, item);
        }

        public void ModifySorted(object item, int index)
        {
            RemoveAt(index);

            int position = BinarySearch(item);

            if(position < 0)
            {
                position = ~position;
            }

            Insert(position, item);
        }
    }
}
