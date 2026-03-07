using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;

namespace MMBSoftware.Services
{
    public interface ICustomerService
    {
        Task AddCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task DeleteCustomer(int customerId);

        Task InitiaInitializeAsync();
        Task<IEnumerable<Customer>> GetCustomers();
        Task<IEnumerable<Customer>> GetAllCustomers();
        IEnumerable<Customer> SearchCustomersByTerm(string searchTerm);
        IEnumerable<Customer> SearchCustomersById(int id);
    }
}
