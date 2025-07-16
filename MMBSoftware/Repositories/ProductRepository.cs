
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
        public void AddProduct(Product product)
        {
            var productList = new List<Product>();
            decimal price = product.Price < 0 ? 0 : product.Price;
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
                command.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;
                var executer = command.ExecuteNonQuery();
            }
        }
        public void UpdateProduct(Product product)
        {
            var productList = new List<Product>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
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
                var executer = command.ExecuteNonQuery();
            }
        }
        public void DeleteProduct(int Id)
        {
            var productList = new List<Product>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"DELETE FROM Product
                                        WHERE Product_Id = @id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<Product> GetAll()
        {
            var productList = new List<Product>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Product";
                using (var reader = command.ExecuteReader())
                {
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
                }
            }

            return productList;
        }
        public IEnumerable<Product> GetByValue(string value)
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
                using (var reader = command.ExecuteReader())
                {
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
                }
            }

            return productList;
        }
        public IEnumerable<Product> GetByCategory(string category)
        {
            // Implementation for getting products by category
            return new List<Product>();
        }
        public IEnumerable<Product> GetByPriceRange(decimal minPrice, decimal maxPrice)
        {
            // Implementation for getting products by price range
            return new List<Product>();
        }
    }
}
