using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Models
{
    public interface IStockRepository
    {
        Task Add(Stock stockModel);
        Task Update(Stock stockModel);
        Task Delete(int Id);


        Task<IEnumerable<Stock>> GetAll();
        Task<IEnumerable<Stock>> GetByValue(string searchTerm);
    }
}
