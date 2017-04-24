using Engine.BuilderPattern.PatternVersion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.BuilderPattern.PatternVersion
{
    [TestClass]
    public class TestPatternReport
    {
        [TestMethod]
        public void Test_BuildReports()
        {
            Report currentMonthTaxReport =
                ReportBuilder.CreateMonthTaxReport(4, 2017);

            Report currentYearTaxReport =
                ReportBuilder.CreateYearTaxReport(2017);

            Report currentMonthCommissionReport =
                ReportBuilder.CreateMonthCommissionReport(4, 2017);

            Report currentYearCommissionReport =
                ReportBuilder.CreateYearCommissionReport(2017);
        }
    }
}