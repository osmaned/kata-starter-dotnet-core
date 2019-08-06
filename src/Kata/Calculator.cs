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

            
            s = s.Replace("//", "");
            
            
            char[] separators = new[] {',', '\n',';'};
            var numbers = s.Split(separators)
                .Where(x=> !string.IsNullOrEmpty(x))
                .Select(x=> Convert.ToInt32(x)).ToList();
            return numbers.Sum();
        }
    }
}