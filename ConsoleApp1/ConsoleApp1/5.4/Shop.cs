using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shop
    {
        Laptop[] laptops;
        public int Amount
        {
            get
            {
                return laptops.Length;
            }
        }

        public Shop(int amount)
        {
            laptops = new Laptop[amount];
        }

        public Shop(Laptop[] laptops)
        {
            this.laptops = laptops;
        }

        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < laptops.Length)
                {
                    return laptops[index];
                }
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < laptops.Length)
                {
                    laptops[index] = value;
                }
                else throw new IndexOutOfRangeException();
            }
        }
    }
}
