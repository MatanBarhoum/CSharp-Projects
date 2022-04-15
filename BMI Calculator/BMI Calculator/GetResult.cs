using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMI_Calculator.Mathematics;

namespace BMI_Calculator
{
    public static class GetResult
    {
        public static string UserResult()
        {
     
            if (Program.RoundedResult < 16) { return "Your BMI score is " + Program.RoundedResult + " and " + "Your condition is Severe Thinness" + " " + "Please consult a doctor"; }
            if (Program.RoundedResult >= 16 && Program.RoundedResult <= 17) { return "Your BMI score is " + Program.RoundedResult + " and " + "Your condition is Moderate Thinness " + "Please consult a doctor!"; }
            if (Program.RoundedResult >= 17 && Program.RoundedResult <= 18.5) { return "Your BMI score is " + Program.RoundedResult + " and " + "Your condition is Mild Thinness " + "Almost normal condition, consider eating more."; }
            if (Program.RoundedResult >= 18.5 && Program.RoundedResult <= 25) { return "Your BMI score is " + Program.RoundedResult + " and " + "Your condition is Normal " + "You're doing fine!"; }
            if (Program.RoundedResult >= 25 && Program.RoundedResult <= 30) { return "Your BMI score is " + Program.RoundedResult + " and " + "Your condition is overweight " + "Please consider eating less and consult a doctor immediatlly!"; }
            else
            {
                return "Your BMI score is " + Program.RoundedResult + " " + "Please consult a doctor about your situation, it could be dangerous.";
            }
        }
    }
}
