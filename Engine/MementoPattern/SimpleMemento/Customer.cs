namespace Engine.MementoPattern.SimpleMemento
{
    public class Customer
    {
        private readonly string _originalAddress;
        private readonly string _originalCity;
        // These are the memento variables, which hold the original values.
        private readonly string _originalName;
        private readonly string _originalPostalCode;
        private readonly string _originalStateProvince;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }

        // Using the memento, to detect if the object has any changes.
        public bool IsDirty
        {
            get
            {
                return Name != _originalName ||
                       Address != _originalAddress ||
                       City != _originalCity ||
                       StateProvince != _originalStateProvince ||
                       PostalCode != _originalPostalCode;
            }
        }

        public Customer(int id, string name, string address, string city, string stateProvince, string postalCode)
        {
            ID = id;
            Name = name;
            Address = address;
            City = city;
            StateProvince = stateProvince;
            PostalCode = postalCode;

            // Save the originally-passed values to the "memento" variables.
            _originalName = name;
            _originalAddress = address;
            _originalCity = city;
            _originalStateProvince = stateProvince;
            _originalPostalCode = postalCode;
        }

        public void RevertToOriginalValues()
        {
            Name = _originalName;
            Address = _originalAddress;
            City = _originalCity;
            StateProvince = _originalStateProvince;
            PostalCode = _originalPostalCode;
        }
    }
}