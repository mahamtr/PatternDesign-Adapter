using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Target
{
    public interface ICalculator
    {
        int Add(int[] numbers);
    }
}
