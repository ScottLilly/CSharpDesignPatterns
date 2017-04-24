using System;
using Engine.BuilderPattern.NonPatternVersion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.BuilderPattern.NonPatternVersion
{
    [TestClass]
    public class TestNonPatternReport
    {
        [TestMethod]
        public void Test_BuildReports()
        {
            DateTime now = DateTime.UtcNow;

            Report currentMonthTaxReport =
                new Report(new DateTime(now.Year, now.Month, 1),
                           new DateTime(now.Year, now.Month, 1).AddMonths(1).AddSeconds(-1),
                           false, true, Report.SortingMethod.ByTaxCategory);

            Report currentYearTaxReport =
                new Report(new DateTime(now.Year, 1, 1),
                           new DateTime(now.Year, 12, 31),
                           false, true, Report.SortingMethod.ByTaxCategory);

            Report currentMonthCommissionReport =
                new Report(new DateTime(now.Year, now.Month, 1),
                           new DateTime(now.Year, now.Month, 1).AddMonths(1).AddSeconds(-1),
                           false, false, Report.SortingMethod.BySalesperson);

            Report currentYearCommissionReport =
                new Report(new DateTime(now.Year, 1, 1),
                           new DateTime(now.Year, 12, 31),
                           false, false, Report.SortingMethod.BySalesperson);
        }
    }
}