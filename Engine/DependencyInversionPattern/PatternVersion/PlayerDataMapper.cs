using System.Data;
using System.Data.SqlClient;

namespace Engine.DependencyInversionPattern.PatternVersion
{
    public class PlayerDataMapper : IPlayerDataMapper
    {
        private readonly string _connectionString =
            "Data Source=(local);Initial Catalog=MyGame;Integrated Security=True";

        public bool PlayerNameExistsInDatabase(string name)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using(SqlCommand playersWithThisName = connection.CreateCommand())
                {
                    playersWithThisName.CommandType = CommandType.Text;
                    playersWithThisName.CommandText = "SELECT count(*) FROM Player WHERE 'Name' = @Name";

                    playersWithThisName.Parameters.AddWithValue("@Name", name);

                    // Get the number of player with this name 
                    var existingRowCount = (int)playersWithThisName.ExecuteScalar();

                    // Result is 0, if no player exists, or 1, if a player already exists
                    return existingRowCount > 0;
                }
            }
        }

        public void InsertNewPlayerIntoDatabase(string name)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using(SqlCommand playersWithThisName = connection.CreateCommand())
                {
                    playersWithThisName.CommandType = CommandType.Text;
                    playersWithThisName.CommandText = "INSERT INTO Player ([Name]) VALUES (@Name)";

                    playersWithThisName.Parameters.AddWithValue("@Name", name);

                    playersWithThisName.ExecuteNonQuery();
                }
            }
        }
    }
}