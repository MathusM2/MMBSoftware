using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MMBSoftware.Models;

namespace MMBSoftware.Services
{
    public class StockService : IStockService
    {
        // Fields
        private readonly IStockRepository _repository;
        private IEnumerable<Stock> _stocksList;

        // Constructor
        public StockService(IStockRepository stockRepository)
        {
            _repository = stockRepository ?? throw new ArgumentNullException(nameof(stockRepository));
        }

        // Properties
        public IEnumerable<Stock> StocksList
        {
            get { return _stocksList; }
            set { _stocksList = value; }
        }

        // Methods

        public async Task InitiaInitializeAsync()
        {
            _stocksList = await _repository.GetAll();
        }

        #region CRUD Operations
        public async Task AddStock(Stock stockModel)
        {
            try
            {
                await _repository.Add(stockModel);;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task UpdateStock(Stock stockModel)
        {
            try
            {
                await _repository.Update(stockModel);
            }
            catch(Exception)
            {
                throw;
            }
        }
        public async Task DeleteStock(int Id)
        {
            await _repository.Delete(Id);
        }

        #endregion

        #region Search Methods
        public IEnumerable<Stock> SearchStocksById(int id)
        {
            try
            {
                var result = _stocksList.Where(p => p.Id == id);
                if(result != null && result.Any())
                {
                    return result;
                }
                else
                {
                    return new List<Stock>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<Stock> SearchStocksByTerm(string searchTerm)
        {
            try
            {
                var result = _stocksList.Where(p => p.Product_Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
                if(result != null && result.Any())
                {
                    return result;
                }
                else
                {
                    return new List<Stock>();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region DataLoad Methods
        public async Task<IEnumerable<Stock>> GetStocks()
        {
            return _stocksList != null ? _stocksList :
                await _repository.GetAll();
        }



        public async Task<IEnumerable<Stock>> GetAllStocks()
        {
            try
            {
                _stocksList = await _repository.GetAll();
                return _stocksList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
