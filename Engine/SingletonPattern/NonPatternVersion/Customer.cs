using System;

namespace Engine.SingletonPattern.NonPatternVersion
{
    public class Customer
    {
        private readonly Logger _logger;

        public string Name { get; set; }

        public Customer(string name)
        {
            _logger = Logger.GetLogger();

            Name = name;
        }

        public void UpdateAddress(string streetAddress, string city)
        {
            // Pretend we update the database, and/or do other things here.

            // Now, write a log message, so we have a record of the update.
            _logger.WriteMessage(string.Format("Updated the address for: {0} at: {1}", Name, DateTime.Now));
        }
    }
}