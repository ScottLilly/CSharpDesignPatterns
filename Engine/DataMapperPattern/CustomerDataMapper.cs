using System.Data;
using System.Data.SqlClient;

namespace Engine.DataMapperPattern
{
    public class CustomerDataMapper
    {
        private const string CONNECTION_STRING =
            "Data Source=(local);Initial Catalog=DesignPatterns;Integrated Security=True";

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

                        var name = (string)reader["Name"];
                        var isPremiumMember = (bool)reader["IsPremiumMember"];

                        return new Customer(id, name, isPremiumMember);
                    }
                }
            }

            return null;
        }

        // Notice that we need to pass in the Customer object (or some information from it)
        // to use some of the methods in the DataMapper class.

        public void Save(Customer customer)
        {
            // This method needs to handle INSERT (new Customer) and UPDATE (existing Customer).
            // Or, you would need to create two separate functions, and call them when appropriate.

            // Pretend there is code here to do the insert and/or update to the database.
        }

        // We also could have only passed in the ID for this method, 
        // because that is the only value from the Customer object that this method needs.
        public void Delete(Customer customer)
        {
            using(SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using(SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "DELETE FROM [Customer] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", customer.ID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}