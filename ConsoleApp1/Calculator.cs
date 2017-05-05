using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator : ICalculator<double>
    {
        public double CalculateMax(double[] array)
        {
            return array.Max();
        }

        public double CalculateMin(double[] array)
        {
           return array.Min();
        }
    }
}
