using System.Collections.Generic;
using System.Linq;

namespace Engine.StrategyPattern.PatternVersion
{
    public class AverageByMean : IAveragingMethod
    {
        public double AverageFor(List<double> values)
        {
            // Simple method to calculate average: 
            // sum of all values, divided by number of values.
            return values.Sum() / values.Count;
        }
    }
}