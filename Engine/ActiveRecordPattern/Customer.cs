using System.Data;
using System.Data.SqlClient;

namespace Engine.ActiveRecordPattern
{
    public class Customer
    {
        private const string CONNECTION_STRING =
            "Data Source=(local);Initial Catalog=DesignPatterns;Integrated Security=True";

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsPremiumMember { get; set; }

        // The constructor could be made "private", 
        // with instantiation handled by static functions like "GetByID()".
        public Customer(int id, string name, bool isPremiumMember)
        {
            ID = id;
            Name = name;
            IsPremiumMember = isPremiumMember;
        }

        // This static method acts like an object factory for Customer objects,
        // reading the values from the database and creating the object.
        //
        // So, the code to get a customer from the database might be:
        //
        //    Customer.GetByID(123);
        //
        public static Customer GetByID(int id)
        {
            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "SELECT TOP 1 * FROM [Customer] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();

                    // If the query returned a row, create the Customer object and return it.
                    if(reader.HasRows)
                    {
                        reader.Read();

                        string name = (string)reader["Name"];
                        bool isPremiumMember = (bool)reader["IsPremiumMember"];

                        return new Customer(id, name, isPremiumMember);
                    }
                }
            }

            return null;
        }

        public void Save()
        {
            // This method needs to handle INSERT (new Customer) and UPDATE (existing Customer).
            // Or, you would need to create two separate functions, and call them when appropriate.

            // This function would not need to receive a parameter, with the Customer object.
            // It's inside the Customer object, so all the property values are already available to it.

            // Pretend there is code here to do the insert and/or update to the database.
        }

        public void Delete()
        {
            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "DELETE FROM [Customer] WHERE [ID] = @ID";
                    // This method uses the ID value from this object's property.
                    // This function didn't need to receive that value from a parameter.
                    command.Parameters.AddWithValue("@ID", ID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}