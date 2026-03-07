using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;

namespace MMBSoftware.Services
{
    public interface IStockService
    {
        Task AddStock(Stock stockModel);
        Task UpdateStock(Stock stockModel);
        Task DeleteStock(int Id);

        Task InitiaInitializeAsync();
        Task<IEnumerable<Stock>> GetStocks();
        Task<IEnumerable<Stock>> GetAllStocks();
        IEnumerable<Stock> SearchStocksByTerm(string searchTerm);
        IEnumerable<Stock> GetFilteredStocks(IFilter filter);
        IEnumerable<Stock> SearchStocksById(int id);

    }
}
