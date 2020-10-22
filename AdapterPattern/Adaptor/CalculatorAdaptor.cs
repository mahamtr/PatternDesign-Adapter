using AdapterPattern.Adaptee;
using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Adaptor
{
    public class CalculatorAdaptor : StringCalculator, ICalculator
    {
        public int Add(int[] numbers)
        {
            var numbersString = string.Join(",", numbers);
            return this.AddNumbers(numbersString);
        }
    }
}
