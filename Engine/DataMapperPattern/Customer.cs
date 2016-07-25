namespace Engine.DataMapperPattern
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsPremiumMember { get; set; }

        public Customer(int id, string name, bool isPremiumMember)
        {
            ID = id;
            Name = name;
            IsPremiumMember = isPremiumMember;
        }
    }
}