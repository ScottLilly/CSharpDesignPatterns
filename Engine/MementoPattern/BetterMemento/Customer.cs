namespace Engine.MementoPattern.BetterMemento
{
    public class Customer
    {
        // This is the memento object, which holds the original values.
        private readonly CustomerMemento _customerMemento;

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }

        public bool IsDirty
        {
            get
            {
                return Name != _customerMemento.Name ||
                       Address != _customerMemento.Address ||
                       City != _customerMemento.City ||
                       StateProvince != _customerMemento.StateProvince ||
                       PostalCode != _customerMemento.PostalCode;
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

            // Save the originally-passed values to the "memento".
            _customerMemento = new CustomerMemento(name, address, city, stateProvince, postalCode);
        }

        public void RevertToOriginalValues()
        {
            Name = _customerMemento.Name;
            Address = _customerMemento.Address;
            City = _customerMemento.City;
            StateProvince = _customerMemento.StateProvince;
            PostalCode = _customerMemento.PostalCode;
        }

        // This is one of the rare cases where you might declare more than one class in a file.
        // The CustomerMemento class will never be used any place, other than in the Customer class.
        // So, you can make it a private class inside the one class where it's used.
        // Or, you could put it in its own file, and declare it an internal or public class.
        private class CustomerMemento
        {
            public string Name { get; private set; }
            public string Address { get; private set; }
            public string City { get; private set; }
            public string StateProvince { get; private set; }
            public string PostalCode { get; private set; }

            public CustomerMemento(string name, string address,
                string city, string stateProvince, string postalCode)
            {
                Name = name;
                Address = address;
                City = city;
                StateProvince = stateProvince;
                PostalCode = postalCode;
            }
        }
    }
}