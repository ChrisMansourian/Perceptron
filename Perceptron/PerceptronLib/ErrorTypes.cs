using System;
using System.Collections.Generic;
using System.Text;

namespace PerceptronLibrary
{
    public class ErrorTypes
    {
        public static double MeanAbsoluteError(double actual, double expected)
        {
            return Math.Abs(expected - actual);
        }

        public static double MeanSquaredError(double actual, double expected)
        {
            return Math.Pow(actual - expected, 2);
        }
    }
}
