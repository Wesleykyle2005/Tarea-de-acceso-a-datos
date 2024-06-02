using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModels;

namespace InventoryCRUD
{
    public class InventoryRepository : IRepository<Inventory>
    {
        public readonly string _connectionString;
        public InventoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IEnumerable<Inventory> GetAll()
        {
            List<Inventory> inventories = new List<Inventory>();
            string queryString = "SELECT Id, MakeId, Color, PetName from Inventory";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) {
                            inventories.Add(new Inventory()
                            {
                                Id = reader.GetInt32(0),
                                MakeId = reader.GetInt32(1),
                                PetName = reader.GetString(2),
                                Color = reader.GetString(3),                                
                            });                                           
                        }                    
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el inventario en la base de datos: {ex.Message}");
            }
            return inventories; 
        }

        public Inventory GetValue(int id)
        {
            string queryString = "SELECT Id, MakeId, PetColor, Color From Inventory Where Id= @id";
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
                            Inventory inventory = new Inventory
                            {
                                Id = reader.GetInt32(0),
                                MakeId = reader.GetInt32(1),
                                PetName = reader.GetString(2),
                                Color = reader.GetString(3) 
                            };
                            return inventory;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener el inventario de la base de datos: {ex.Message}");

            }
            return null;
        }

        public void Insert(Inventory inventory)
        {
            string queryString = "INSERT INTO Inventory(MakeId, PetName, Color) VALUES (@makeId, @petName, @color)";
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@makeId", inventory.MakeId);
                    command.Parameters.AddWithValue("@petName", inventory.PetName);
                    command.Parameters.AddWithValue("@color", inventory.Color);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar en la base de datos {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            if (canDelete(id))
            {
                string queryString = "DELETE FROM Inventory WHERE Id = @id";

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
                    throw new Exception($"Error al eliminar de la base de datos {ex.Message}");
                } 
            }            
        }

        private bool canDelete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Orders WHERE CarId = @InventoryId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@InventoryId", id);

                int count = (int)command.ExecuteScalar();
                return count == 0;
            }
        }

        public void Update(Inventory inventory)
        {
            String queryString = "UPDATE Inventory SET MakeId = @makeId, PetName = @petname, Color = @color  WHERE Id = @id";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@makeId", inventory.MakeId);
                command.Parameters.AddWithValue("@petname", inventory.PetName);
                command.Parameters.AddWithValue("@color", inventory.Color);
                command.Parameters.AddWithValue("id", inventory.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
