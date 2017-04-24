using System;

namespace Engine.BuilderPattern.PatternVersion
{
    public class ReportBuilder
    {
        private static Report CreateTaxReport(DateTime from, DateTime to)
        {
            return new Report(from, to, false, true, Report.SortingMethod.ByTaxCategory);
        }

        public static Report CreateMonthTaxReport(int month, int year)
        {
            return CreateTaxReport(new DateTime(year, month, 1),
                                   new DateTime(year, month, 1).AddMonths(1).AddSeconds(-1));
        }

        public static Report CreateYearTaxReport(int year)
        {
            return CreateTaxReport(new DateTime(year, 1, 1),
                                   new DateTime(year, 12, 31));
        }

        private static Report CreateCommissionReport(DateTime from, DateTime to)
        {
            return new Report(from, to, false, false, Report.SortingMethod.BySalesperson);
        }

        public static Report CreateMonthCommissionReport(int month, int year)
        {
            return CreateCommissionReport(new DateTime(year, month, 1),
                                          new DateTime(year, month, 1).AddMonths(1).AddSeconds(-1));
        }

        public static Report CreateYearCommissionReport(int year)
        {
            return CreateCommissionReport(new DateTime(year, 1, 1),
                                          new DateTime(year, 12, 31));
        }
    }
}