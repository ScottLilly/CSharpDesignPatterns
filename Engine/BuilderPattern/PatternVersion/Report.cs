using System;

namespace Engine.BuilderPattern.PatternVersion
{
    public class Report
    {
        public enum SortingMethod
        {
            BySalesperson,
            ByTaxCategory
        }

        private DateTime _fromDate;
        private DateTime _toDate;
        private bool _includeReturnedOrders;
        private bool _includeUnshippedOrders;
        private SortingMethod _sortBy;

        public Report(DateTime from, DateTime to,
                      bool includeReturnedOrders, bool includeUnshippedOrders, SortingMethod sortBy)
        {
            _fromDate = from;
            _toDate = to;
            _includeReturnedOrders = includeReturnedOrders;
            _includeUnshippedOrders = includeUnshippedOrders;
            _sortBy = sortBy;
        }

        public object CreatePDFReport()
        {
            // Pretend this object is a PDF report, 
            // built for the sales that match the passed-in constructor parameters.
            return new object();
        }
    }
}