using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using MMBSoftware.Models;
using MMBSoftware.Models.Enums;

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
            _stocksList = await _repository.GetAll().ConfigureAwait(false);
        }

        #region CRUD Operations
        public async Task AddStock(Stock stockModel)
        {
            try
            {
                await _repository.Add(stockModel).ConfigureAwait(false);
                _stocksList = await _repository.GetAll().ConfigureAwait(false);
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
                await _repository.Update(stockModel).ConfigureAwait(false);
                _stocksList = await _repository.GetAll().ConfigureAwait(false);
            }
            catch(Exception)
            {
                throw;
            }
        }
        public async Task DeleteStock(int Id)
        {
            await _repository.Delete(Id).ConfigureAwait(false);
            _stocksList = await _repository.GetAll().ConfigureAwait(false);
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

        public IEnumerable<Stock> GetFilteredStocks(IFilter filter)
        {
            try
            {
                var query = _stocksList.AsQueryable();
                if(filter.ExpirationFilter != null)
                {
                    if (filter.ExpirationFilter == true)
                        query = query.Where(s => s.Expiry_Date < DateTime.Now);
                    else
                        query = query.Where(s => s.Expiry_Date >= DateTime.Now);
                }

                if(filter.SituationFilter != null)
                {
                    if (filter.SituationFilter == true)
                        query = query.Where(s => s.Quantity > 0);
                    else
                        query = query.Where(s => s.Quantity <= 0);
                }

                if(filter.UnitType != null)
                {
                    if (filter.UnitType == UnitType.Unit)
                    {
                        query = query.Where(s => s.Unit_Type == UnitType.Unit);
                    }
                    else if (filter.UnitType == UnitType.Box)
                    {
                        query = query.Where(s => s.Unit_Type == UnitType.Box);
                    }
                    else if (filter.UnitType == UnitType.Package)
                    {
                        query = query.Where(s => s.Unit_Type == UnitType.Package);
                    }

                }

                return query.ToList();
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
                await _repository.GetAll().ConfigureAwait(false);
        }



        public async Task<IEnumerable<Stock>> GetAllStocks()
        {
            try
            {
                _stocksList = await _repository.GetAll().ConfigureAwait(false);
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
