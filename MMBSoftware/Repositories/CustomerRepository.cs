using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MySql.Data.MySqlClient;

namespace MMBSoftware.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        // Constructor
        public CustomerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        #region CRUD Operations
        public async Task Add(Customer customer)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Customer
                                        (Customer_Name,Customer_Email,Customer_Phone, Customer_Address,Customer_CanPlaceOrder, Customer_AccountLimit, Customer_CPF)
                                        VALUES (@name, @email, @phone, @address, @canPlaceOrder, @accountLimit, @cpf)";
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = customer.Name;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = customer.Email;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.Phone;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = customer.Address;
                command.Parameters.Add("@canPlaceOrder", MySqlDbType.Binary).Value = customer.CanPlaceOrder;
                command.Parameters.Add("@accountLimit", MySqlDbType.Int32).Value = customer.AccountLimit;
                command.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = customer.CPF;
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
        public async Task Update(Customer customer)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                await connection.OpenAsync();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customer
                                        SET Customer_Name = @name,
                                            Customer_Email = @email,
                                            Customer_Phone = @phone,
                                            Customer_Address = @address,
                                            Customer_CanPlaceOrder = @canPlaceOrder,
                                            Customer_AccountLimit = @accountLimit,
                                            Customer_CPF = @cpf
                                        WHERE Customer_Id = @id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = customer.Id;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = customer.Name;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = customer.Email;
                command.Parameters.Add("@phone", MySqlDbType.Int64).Value = customer.Phone;
                command.Parameters.Add("@address", MySqlDbType.VarChar).Value = customer.Address;
                command.Parameters.Add("@canPlaceOrder", MySqlDbType.Bit). Value = customer.CanPlaceOrder == true ? 1 : 0;
                command.Parameters.Add("@accountLimit", MySqlDbType.Int32).Value = customer.AccountLimit;
                command.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = customer.CPF;
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

        public async Task Delete(int customerId)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"DELETE From Customer
                                        WHERE Customer_Id = @id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = customerId;
                try
                {
                    await command.ExecuteNonQueryAsync();
                }
                catch(MySqlException)
                {
                    throw;
                }
            }
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var command = new MySqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT *FROM Customer";

                    using (var reader = command.ExecuteReader())
                    {
                        var customerList = new List<Customer>();
                        while (reader.Read())
                        {
                            var customerModel = new Customer();
                            customerModel.Id = (int)reader[0];
                            customerModel.Name = reader[1].ToString();
                            customerModel.CPF = reader[2].ToString();
                            customerModel.Email = reader[3].ToString();
                            customerModel.Phone = reader[4].ToString();
                            customerModel.Address = reader[5].ToString();
                            customerModel.CanPlaceOrder = Convert.ToBoolean(reader.GetSByte(6));
                            customerModel.AccountLimit = (int)reader[7];

                            customerList.Add(customerModel);
                        }

                        return customerList;
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public Task<IEnumerable<Customer>> GetByValue(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAccountOrders()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
