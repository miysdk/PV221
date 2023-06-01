using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IWorker
    {
        bool IsWorking { get; }
        string Work();
    }

    public interface IManager
    {
        List<IWorker> Workers { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }

    public class Director : Employee, IManager
    {
        public List<IWorker> Workers { get; set; }

        public void Control()
        {
            Console.WriteLine("Controlling...");
        }

        public void MakeBudget()
        {
            Console.WriteLine("Making Budget...");
        }

        public void Organize()
        {
            Console.WriteLine("Organizing...");
        }
    }

    public class Seller : Employee, IWorker
    {
        bool isWorking = false;
        public bool IsWorking
        {
            get
            {
                return isWorking;
            }
        }

        public string Work()
        {
            return "Selling products...";
        }
    }

    public class Cashier : Employee, IWorker
    {
        bool isWorking = false;
        public bool IsWorking
        {
            get
            {
                return isWorking;
            }
        }

        public string Work()
        {
            return "Accepting payment...";
        }
    }

    public class Storekeeper : Employee, IWorker
    {
        bool isWorking = false;
        public bool IsWorking
        {
            get
            {
                return isWorking;
            }
        }

        public string Work()
        {
            return "Storing products...";
        }
    }
}
