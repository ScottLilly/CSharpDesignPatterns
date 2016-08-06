using System;
using System.Collections.Generic;
using System.Linq;

namespace Engine.StrategyPattern.NonPatternVersion_SingleMethod
{
    public class Calculator
    {
        public enum AveragingMethod
        {
            Mean,
            Median
        }

        public double CalculateAverage(List<double> values, AveragingMethod averagingMethod)
        {
            switch(averagingMethod)
            {
                case AveragingMethod.Mean:
                    return values.Sum() / values.Count;

                case AveragingMethod.Median:
                    var sortedValues = values.OrderBy(x => x).ToList();

                    if(sortedValues.Count % 2 == 1)
                    {
                        return sortedValues[(sortedValues.Count - 1) / 2];
                    }

                    return (sortedValues[(sortedValues.Count / 2) - 1] + 
                        sortedValues[sortedValues.Count / 2]) / 2;

                default:
                    throw new ArgumentException("Invalid averagingMethod value");
            }
        }
    }
}
