using System.Collections.Generic;

namespace Engine.StrategyPattern.PatternVersion
{
    public interface IAveragingMethod
    {
        double AverageFor(List<double> values);
    }
}