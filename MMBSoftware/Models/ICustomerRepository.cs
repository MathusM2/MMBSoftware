using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Models
{
    public interface ICustomerRepository
    {
        Task Add(Customer customer);
        Task Update(Customer customer);
        Task Delete(int customerId);

        Task<IEnumerable<Customer>> GetAll();
        Task<IEnumerable<Customer>> GetByValue(string searchTerm);
        Task<IEnumerable<Order>> GetAccountOrders();
    }
}
