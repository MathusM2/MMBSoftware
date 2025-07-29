using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Models
{
    public interface IProductRepository
    {
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(int productId);


        Task<IEnumerable<Product>> GetAll();
        Task<IEnumerable<Product>> GetByValue(string searchTerm);

    }
}
