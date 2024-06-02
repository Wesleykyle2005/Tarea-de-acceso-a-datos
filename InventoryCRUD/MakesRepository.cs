using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SharedModels;

namespace InventoryCRUD
{
    public class MakesRepository : IRepository<Makes>
    {

        public readonly string _connectionString;
        
        public MakesRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Makes> GetAll()
        {
            List<Makes> makes = new List<Makes>();

            string queryString = "Select Id, Name, TimeStamp from Makes";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            makes.Add(new Makes()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),                                
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error las marcas de la base de datos: {ex.Message}");
            }
            return makes;
        }

        public Makes GetValue(int id)
        {
            string queryString = "SELECT Id, Name From Makes Where Id= @id";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);    
                    command.Parameters.AddWithValue("id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Makes make = new Makes
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                            };
                            return make;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error la marca de la base de datos: {ex.Message}");
            }
            return null;
        }

        public void Insert(Makes make)
        {
            string queryString = "INSERT INTO Makes(Name) VALUES (@name)";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@name", make.Name);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error la marca de la base de datos: {ex.Message}");
            }
        }

        public void Update(Makes make)
        {
            try
            {
                String queryString = "UPDATE Makes SET Name = @name WHERE Id = @id";
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@name", make.Name);
                    command.Parameters.AddWithValue("@id", make.Id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar la marca de la base de datos: {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            if (CanDeleteMake(id))
            {
                string queryString = "DELETE FROM Makes WHERE Id = @id";

                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error al eliminar la marca de la base de datos: {ex.Message}");
                } 
            }
        }

        public bool CanDeleteMake(int makeId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Inventory WHERE MakeId = @MakeId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MakeId", makeId);

                int count = (int)command.ExecuteScalar();
                return count == 0;
            }
        }
    }
}
