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

            char[] separators = new[] {',', '\n'};
            var numbers = s.Split(separators).Select(int.Parse).ToList();
            return numbers.Sum();
        }
    }
}