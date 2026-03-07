using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MMBSoftware.Models.Enums;
using MySql.Data.MySqlClient;

namespace MMBSoftware.Repositories
{
    public class StockRepository : BaseRepository, IStockRepository
    {
        //Consctructor
        public StockRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Methods
        #region CRUD Operations
        public async Task Add(Stock stockModel)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Stock (Product_Id, Quantity, Unit_Type, Entry_Date, Expiry_Date)
                                        VALUES (@productId, @quantity, @unitType, @entryDate, @expiryDate)";
                command.Parameters.Add("@productId", MySqlDbType.Int32).Value = stockModel.ProductId;
                command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = stockModel.Quantity;
                command.Parameters.Add("@unitType", MySqlDbType.Int32).Value = stockModel.Unit_Type;
                command.Parameters.Add("@entryDate", MySqlDbType.Date).Value = stockModel.Entry_Date;
                command.Parameters.Add("@expiryDate", MySqlDbType.Date).Value = stockModel.Expiry_Date;
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
        public async Task Update(Stock stockModel)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {

                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = @"UPDATE Stock
                                SET Product_Id = @productId,
                                    Quantity = @quantity,
                                    Unit_Type = @unitType,
                                    Entry_Date = @entryDate,
                                    Expiry_Date = @expiryDate
                                WHERE (Stock_Id = @id)";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = stockModel.Id;
                command.Parameters.Add("@productId", MySqlDbType.Int32).Value = stockModel.ProductId;
                command.Parameters.Add("@quantity", MySqlDbType.Int32).Value = stockModel.Quantity;
                command.Parameters.Add("@unitType", MySqlDbType.Int32).Value = stockModel.Unit_Type;
                command.Parameters.Add("@entryDate", MySqlDbType.DateTime).Value = stockModel.Entry_Date.Date;
                command.Parameters.Add("@expiryDate", MySqlDbType.DateTime).Value = stockModel.Expiry_Date.Date;
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
                command.CommandText = @"DELETE FROM Stock
                                        WHERE Stock_Id = @id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
                try
                {
                    await command.ExecuteNonQueryAsync();
                }
                catch (MySqlException ex)
                {
                    throw;
                }
            }
        }

        public async Task<IEnumerable<Stock>> GetAll()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var command = new MySqlCommand())
                {
                    await connection.OpenAsync();
                    command.Connection = connection;
                    command.CommandText = @"SELECT 
                                        p.Product_Name AS Nome,
                                        s.Quantity,
                                        s.Unit_Type,
                                        p.Product_Category AS Category,
                                        s.Entry_Date,
                                        s.Expiry_Date,
                                        s.Stock_Id,
                                        s.Product_Id
                                        FROM Stock s
                                        JOIN Product p ON s.Product_Id = p.Product_Id";
                    using (var reader = command.ExecuteReader())
                    {
                        List<Stock> stockList = new List<Stock>();
                        while (reader.Read())
                        {
                            Stock StockModel = new Stock();
                            StockModel.Product_Name = reader.GetString("Nome");
                            StockModel.Quantity = reader.GetInt32("Quantity");
                            StockModel.Unit_Type = ToUnitTypeExtensions.IntToUnitType(reader.GetInt32("Unit_Type"));
                            StockModel.Unit_TypeDisplay = UnitTypeToStringExtensions.IntToString(reader.GetInt32("Unit_Type"));
                            StockModel.Product_Category = reader.GetString("Category");
                            StockModel.Entry_Date = reader.GetDateTime("Entry_Date");
                            
                            StockModel.Expiry_Date = reader.GetDateTime("Expiry_Date");
                            StockModel.ProductId = reader.GetInt32("Product_Id");
                            StockModel.Id = reader.GetInt32("Stock_Id");
                            stockList.Add(StockModel);
                        }

                        return stockList;
                    }
                }
            }
            catch (MySqlException)
            {
                throw;
            }
        }
        public async Task<IEnumerable<Stock>> GetByValue(string searchTerm)
        {
            List<Stock> stockList = new List<Stock>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT p.product_name, s.quantity, s.unit_type, s.entry_date,s.stock_Id, s.product_Id
                                        FROM Stock s
                                        JOIN Product p ON s.product_Id = p.product_Id
                                        WHERE p.product_name LIKE @name
                                        ORDER BY Stock_Id desc";
                command.Parameters.Add("@stock_id", MySqlDbType.Int32).Value = int.TryParse(searchTerm, out int id) ? id : 0;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = searchTerm + "%";
                try
                {
                    var reader = await command.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        Stock stockItem = new Stock();
                        
                        stockItem.Product_Name = reader.GetString(0);
                        stockItem.Quantity = reader.GetInt32(1);
                        stockItem.Unit_Type = ToUnitTypeExtensions.IntToUnitType(reader.GetInt32(2));
                        stockItem.Entry_Date = reader.GetDateTime(3);
                        stockItem.Expiry_Date = reader.GetDateTime(4);
                        stockItem.Id = reader.GetInt32(5);
                        stockItem.ProductId = reader.GetInt32(6);
                        stockList.Add(stockItem);
                    }

                    return stockList;
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
