using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MultiArray
    {
        int[,] array;
        public int Rows
        {
            get { return array.GetLength(0); }
        }
        public int Cols
        {
            get { return array.GetLength(1); }
        }

        public MultiArray(int rows, int cols)
        {
            array = new int[rows, cols];
        }
        
        public int this[int r, int c]
        {
            get
            {
                return array[r, c];
            }
            set
            {
                array[r, c] = value;
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(array[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
