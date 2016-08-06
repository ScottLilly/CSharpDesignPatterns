using System.Collections.Generic;
using System.Linq;

namespace Engine.StrategyPattern.PatternVersion
{
    public class AverageByMedian : IAveragingMethod
    {
        public double AverageFor(List<double> values)
        {
            // Median average is the middle value of the values in the list.

            var sortedValues = values.OrderBy(x => x).ToList();

            // Use the "%" (modulus) to determine if there is an even, or odd, number of values.
            if(sortedValues.Count % 2 == 1)
            {
                // Number of values is odd.
                // Return the middle value of the sorted list.
                // REMEMBER: The list's index is zero-based, so we subtract 1, instead of adding 1,
                //           to determine which element of the list to return
                return sortedValues[(sortedValues.Count - 1) / 2];
            }

            // Number of values is even.
            // Return the mean average of the two middle values.
            // REMEMBER: The list's index is zero-based, so we subtract 1, instead of adding 1,
            //           to determine which elements of the list to use
            return (sortedValues[(sortedValues.Count / 2) - 1] + 
                sortedValues[sortedValues.Count / 2]) / 2;
        }
    }
}