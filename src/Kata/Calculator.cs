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
            
            var numbers = s.Split(',').Select(int.Parse).ToList();
            return numbers.Sum();
        }
    }
}