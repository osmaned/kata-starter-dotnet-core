using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if(s=="")
                return 0;
            
            List<string> numbers = s.Split(',').ToList();

            if (numbers.Count == 1)
                return Convert.ToInt32(numbers.ElementAt(0));
            else
                return Convert.ToInt32(numbers.ElementAt(0)) + Convert.ToInt32(numbers.ElementAt(1));
        }
    }
}