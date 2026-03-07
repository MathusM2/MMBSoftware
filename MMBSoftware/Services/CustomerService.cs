using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMBSoftware.Models;

namespace MMBSoftware.Services
{
    public class CustomerService : ICustomerService
    {
        // Fields
        private ICustomerRepository repository;
        private IEnumerable<Customer> _customersList;

        // Constructor
        public CustomerService(ICustomerRepository repository)
        {
            this.repository = repository;
        }

        // Properties
        public IEnumerable<Customer> CustomerList
        {
            get { return _customersList; }
            set { _customersList = value; }
        }

        // Methods
        public async Task InitiaInitializeAsync()
        {
            try
            {
                _customersList = await repository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region Bussines Logic for CRUD Operations
        public async Task AddCustomer(Customer customer)
        {
            try
            {
                await repository.Add(customer);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task UpdateCustomer(Customer customer)
        {
            try
            {
                await repository.Update(customer);
            }
            catch
            {
                throw;
            }
        }

        public async Task DeleteCustomer(int customerId)
        {
            try
            {
                await repository.Delete(customerId);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Search Methods
        public IEnumerable<Customer> SearchCustomersById(int id)
        {
            var result = _customersList.Where(x => x.Id == id);
            if (result != null && result.Any())
            {
                return result;
            }
            else
            {
                return Enumerable.Empty<Customer>();
            }
        }

        public IEnumerable<Customer> SearchCustomersByTerm(string searchTerm)
        {
            var result = _customersList.Where(s => s.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
            if (result != null && result.Any())
            {
                return result;
            }
            else
            {
                return Enumerable.Empty<Customer>();
            }
        }
        #endregion

        #region DataLoad Methods
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            try
            {
                _customersList = await repository.GetAll();
                return _customersList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return _customersList != null ? _customersList :
                await GetAllCustomers();
        }
        #endregion


    }
}
