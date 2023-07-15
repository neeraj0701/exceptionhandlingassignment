using System.Data.SqlClient;
namespace DatabaseAccessException
{
    public class Program
    {
        public static void Main()
        {
            string connectionString = "Server=COGNINE-L3;Database=neer;Integrated Security=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM new";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        Console.WriteLine($"id: {id}, name : {name}");
                    }
                    reader.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}