using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Adaptee
{
    public class StringCalculator
    {
        public int AddNumbers(string numbers)
        {
            var numbersArray = numbers.Split(",").Select(i => int.Parse(i));
            return numbersArray.Sum();
        }

    }
}
