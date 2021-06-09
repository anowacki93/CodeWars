using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codewars
{
    public class Kata
    {
        public string  HighAndLow(string numbers)
        {
            string[] arr =numbers.Split(' ');
            int[] c = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                c[i] = int.Parse(arr[i]);
            }
            return $"{c.Max().ToString()} {c.Min().ToString()}";


        }
    }
}
