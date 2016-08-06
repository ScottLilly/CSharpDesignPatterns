using System.Collections.Generic;

namespace Engine.StrategyPattern.PatternVersion
{
    public class Calculator
    {
        public double CalculateAverageFor(List<double> values, IAveragingMethod averagingMethod)
        {
            return averagingMethod.AverageFor(values);
        }
    }
}