using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMBSoftware.Models;
using MMBSoftware.Presenters.Commom;

namespace MMBSoftware.Services
{
    public class ProductService : IProductService
    {
        // Fields
        private readonly IProductRepository _repository;
        private IEnumerable<Product> _productsList;

        // Constructor
        public ProductService(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        // Properties
        public IEnumerable<Product> ProductList
        {
            get { return _productsList; }
            set { _productsList = value; }
        }

        // Methods

        public async Task InitiaInitializeAsync()
        {
            _productsList = await _repository.GetAll().ConfigureAwait(false);
        }

        #region Bussiness Logic for CRUD Operations
        public async Task CreateProduct(Product product)
        {
            try
            {
                await _repository.Add(product).ConfigureAwait(false);
                _productsList = await _repository.GetAll().ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task UpdateProduct(Product product)
        {
            try
            {
               await _repository.Update(product).ConfigureAwait(false);
                _productsList = await _repository.GetAll().ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        public async Task DeleteProduct(int productId)
        {
            try
            {
                await _repository.Delete(productId).ConfigureAwait(false);
                _productsList = await _repository.GetAll().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region Search Methods
        public IEnumerable<Product> SearchProductsByTerm(string Term)
        {
            try
            {
                var result = _productsList.Where(p => p.Name.Contains(Term, StringComparison.OrdinalIgnoreCase));
                if(result != null && result.Any())
                {
                    return result;
                }
                else
                {
                    return Enumerable.Empty<Product>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<Product> SearchProductsById(int productId)
        {
            try
            {
                var result = _productsList.Where(p => p.Id == productId);
                if (result != null && result.Any())
                {
                    return result;
                }
                else
                {
                    return Enumerable.Empty<Product>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Product> SearchProductByBarcode(string productBarcode)
        {
            try
            {
                var result = _productsList.Where(p => p.Barcode == productBarcode);
                if (result != null && result.Any())
                {
                    Debug.WriteLine(result.ToString());
                    return result;
                }
                else 
                {
                    return Enumerable.Empty<Product>();
                }
            }
            catch (Exception) 
            {                 
                throw;
            }
        }
        #endregion

        #region DataLoad Methods
        public async Task<IEnumerable<Product>> GetProducts()
        {
             return _productsList != null ? _productsList :
                await _repository.GetAll().ConfigureAwait(false);
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            try
            {
                this._productsList = null;
                this._productsList = await _repository.GetAll().ConfigureAwait(false);
                return _productsList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<string> GetCategoriesFromCache()
        {
            return _productsList.Select(p => p.Category).Distinct().Append("Nova categoria");
        }

        public IEnumerable<string> GetNamesFromCache()
        {
            return _productsList.Select(p => p.Name).Distinct();
        }
        #endregion
    }
}
