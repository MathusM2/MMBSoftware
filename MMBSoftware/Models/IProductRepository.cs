using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Models
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetByValue(string searchTerm);
        IEnumerable<Product> GetByCategory(string category);
        IEnumerable<Product> GetByPriceRange(decimal minPrice, decimal maxPrice);

    }
}
