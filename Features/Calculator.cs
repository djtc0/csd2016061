using System;
using System.Collections.Generic;

namespace Features
{
    internal class Calculator
    {
        public List<int> values { get; set; }
        public int result { get; set; }
        public Calculator()
        {
            result = 0;
            values = new List<int>();
        }
        
        public void sumAllValues()
        {
            result = 0;
            foreach (var value in values)
            {
                result += value;
            }
        }
    }
}