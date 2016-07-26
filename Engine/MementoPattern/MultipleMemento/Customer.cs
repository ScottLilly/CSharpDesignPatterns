using System.Collections.Generic;
using System.Linq;

namespace Engine.MementoPattern.MultipleMemento
{
    public class Customer
    {
        // Save a list of memento objects, to allow for multiple "snapshots" of the Customer object.
        private readonly List<CustomerMemento> _customerMementoes = new List<CustomerMemento>();

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
                if(_customerMementoes.Count == 0)
                {
                    return false;
                }

                return Name != _customerMementoes.First().Name ||
                       Address != _customerMementoes.First().Address ||
                       City != _customerMementoes.First().City ||
                       StateProvince != _customerMementoes.First().StateProvince ||
                       PostalCode != _customerMementoes.First().PostalCode;
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

            // Save the originally-passed values to the memento list.
            SaveMemento();
        }

        public void SaveMemento()
        {
            CustomerMemento customerMemento =
                new CustomerMemento(Name, Address, City, StateProvince, PostalCode);

            _customerMementoes.Add(customerMemento);
        }

        public void RevertToOriginalValues()
        {
            // Get the first memento, if there is one (there always should be at least one).
            CustomerMemento firstMemento = _customerMementoes.FirstOrDefault();

            // Check for null, just to be safe.
            if(firstMemento != null)
            {
                SetPropertyValuesFromMemento(firstMemento);

                // Remove all the mementoes, except for the first one.
                if(_customerMementoes.Count > 1)
                {
                    _customerMementoes.RemoveRange(1, _customerMementoes.Count - 1);
                }
            }
        }

        public void RevertToLastValues()
        {
            // Get the last memento, if there is one (there always should be at least one).
            CustomerMemento lastMemento = _customerMementoes.LastOrDefault();

            // Check for null, just to be safe.
            if(lastMemento != null)
            {
                SetPropertyValuesFromMemento(lastMemento);

                // Remove the last memento, unless it's the first one.
                if(lastMemento != _customerMementoes.First())
                {
                    _customerMementoes.Remove(lastMemento);
                }
            }
        }

        private void SetPropertyValuesFromMemento(CustomerMemento memento)
        {
            Name = memento.Name;
            Address = memento.Address;
            City = memento.City;
            StateProvince = memento.StateProvince;
            PostalCode = memento.PostalCode;
        }

        private class CustomerMemento
        {
            public string Name { get; }
            public string Address { get; }
            public string City { get; }
            public string StateProvince { get; }
            public string PostalCode { get; }

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