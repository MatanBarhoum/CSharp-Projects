using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator.Mathematics
{
    public static class Calculator
    {
        public static double BMICalc(double weight, double height)
        {
            return (weight / (height * height));
        }
    }
}
