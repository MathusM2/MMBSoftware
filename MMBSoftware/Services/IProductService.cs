using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;

namespace MMBSoftware.Services
{
    public interface IProductService
    {

        Task CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int productId);

        Task InitiaInitializeAsync();
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Product>> GetAllProducts();
        IEnumerable<Product> SearchProductsByTerm(string Term);
        IEnumerable<Product> SearchProductsById(int Id);
        IEnumerable<string> GetCategoriesFromCache();
        IEnumerable<string> GetNamesFromCache();

    }
}
