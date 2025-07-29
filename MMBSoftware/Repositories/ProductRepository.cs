
using Google.Protobuf.WellKnownTypes;
using MMBSoftware.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace MMBSoftware.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        //Constructor
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        #region CRUD Operations
        public async Task Add(Product product)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Product
                                        (Product_Name, Product_Description, Product_Category, Product_Price)
                                        VALUES (@name, @description, @category, @price) ";
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = product.Name;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = product.Description;
                command.Parameters.Add("@category", MySqlDbType.VarChar).Value = product.Category;
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = product.Price;
                try
                {
                    await command.ExecuteNonQueryAsync();
                }
                catch
                {
                    throw;
                }
            }
        }
        public async Task Update(Product product)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = @"UPDATE Product                                      
                                        SET Product_Name = @name,
                                            Product_Description = @description,
                                            Product_Category = @category,
                                            Product_Price = @price
                                        WHERE (Product_Id = @id)";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = product.Id;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = product.Name;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = product.Description;
                command.Parameters.Add("@category", MySqlDbType.VarChar).Value = product.Category;
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = product.Price;
                try
                {
                    await command.ExecuteNonQueryAsync();
                }
                catch (MySqlException)
                {
                    throw;
                }
            }
        }
        public async Task Delete(int Id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"DELETE FROM Product
                                        WHERE Product_Id = @id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
                try
                {
                    await command.ExecuteNonQueryAsync();
                }
                catch (MySqlException)
                {
                    throw;
                }
            }
        }
        public async Task<IEnumerable<Product>> GetAll()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var command = new MySqlCommand())
                {
                    await connection.OpenAsync();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM Product";
                    using (var reader = command.ExecuteReader())
                    {
                        var productList = new List<Product>();
                        while (reader.Read())
                        {
                            var productModel = new Product();
                            productModel.Id = (int)reader[0];
                            productModel.Name = reader[1].ToString();
                            productModel.Description = reader[2].ToString();
                            productModel.Category = reader[3].ToString();
                            productModel.Price = (decimal)reader[4];
                            productList.Add(productModel);
                        }

                        return productList;
                    }
                }
            }
            catch (MySqlException)
            {
                throw;
            }
        }
        public async Task<IEnumerable<Product>> GetByValue(string value)
        {
            var productList = new List<Product>();
            int product_Id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string product_Name = value;
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product
                                      WHERE Product_Id = @id
                                      OR Product_Name LIKE @name
                                      ORDER BY Product_Id desc ";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = product_Id;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = product_Name + "%";
                try
                {
                    var reader = await command.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        var productModel = new Product();
                        productModel.Id = (int)reader[0];
                        productModel.Name = reader[1].ToString();
                        productModel.Description = reader[2].ToString();
                        productModel.Category = reader[3].ToString();
                        productModel.Price = (decimal)reader[4];
                        productList.Add(productModel);

                    }


                    return productList;
                }
                catch (MySqlException)
                {
                    throw;
                }
            }
        }
        #endregion
    }
}
