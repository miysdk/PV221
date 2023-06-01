using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1._5._25
{
    public static class StringExtantion
    {
        public static int NumberWords(this string data)
        {
            if (string.IsNullOrEmpty(data)) return 0;

            data = Regex.Replace(data.Trim(), @"\s+", " ");

            return data.Split(' ').Length;
        }
    }
}
