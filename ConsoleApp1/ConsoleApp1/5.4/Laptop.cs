using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Laptop
    {
        public string Vendor { get; set; } = "Unnamed";
        public double Price { get; set; }

        public Laptop(string vendor, double price)
        {
            Vendor = vendor;
            Price = price;
        }

        public override string ToString()
        {
            return $"Laptop: {Vendor} - ${Price}";
        }
    }
}
