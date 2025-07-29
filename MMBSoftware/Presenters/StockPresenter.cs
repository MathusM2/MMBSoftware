using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MMBSoftware.Presenters.Commom;
using MMBSoftware.Services;
using MMBSoftware.Views;
using MySqlX.XDevAPI;

namespace MMBSoftware.Presenters
{
    public class StockPresenter
    {
        // Fields
        private IStockView view;
        private IProductService productService;
        private IStockService stockService;
        private BindingSource stockBindingSource;
        private BindingSource selectedProductBindingSource;
        private IEnumerable<Stock> stockList;
        private IEnumerable<string> selectedProductList;

        // Constructor
        public StockPresenter(IStockView view, IProductService productService, IStockService stockService)
        {
            this.stockBindingSource = new BindingSource();
            this.selectedProductBindingSource = new BindingSource();
            this.view = view;
            this.productService = productService;
            this.stockService = stockService;
            // Subscribe to events from the view
            this.stockList = new List<Stock>();
            this.view.AddEvent += AddNewStock;
            this.view.EditEvent += LoadSelectedProductEdit;
            this.view.SelectedProductEvent += SelectedProductAction;
            this.view.SaveEvent += SaveStock;
            this.view.CancelEvent += CancelAction;
            this.view.SearchEvent += SearchStock;
            this.view.DeleteEvent += DeleteSelectedStock;
            // Set the stock list binding source
            this.view.setStockListBindingSource(stockBindingSource);
            this.view.setSelectedProductListBindingSource(selectedProductBindingSource);
            // Show the view
            this.view.Show();
            // Load the stock list
            LoadStockList();
        }

        //Methods
        #region Methods for UI
        private void AddNewStock(object? sender, EventArgs e)
        {
            view.IsEdit = false;
            LoadSelectedProductList();
        }
        private void LoadSelectedProductEdit(object? sender, EventArgs e)
        {
            var StockItem = (Stock)stockBindingSource.Current;
            if (StockItem != null)
            {
                view.Id = StockItem.Id.ToString();
                view.SelectedProduct = StockItem.Product_Name;
                view.ProductId = StockItem.ProductId.ToString();
                view.PdName = StockItem.Product_Name;
                view.Quantity = StockItem.Quantity.ToString();
                view.EntryDate = StockItem.Entry_Date.ToString("yyyy-MM-dd");
                view.IsEdit = true;

            }
        }
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
            view.IsEdit = false;
        }
        private async void SelectedProductAction(object? sender, EventArgs e)
        {
            if (view.IsEdit == false)
            {
                var selectedProduct = await productService.GetProducts();
                selectedProduct = selectedProduct.Where(p => p.Name == view.SelectedProduct).ToList();
                foreach (var item in selectedProduct)
                {
                    view.ProductId = item.Id.ToString();
                    view.PdName = item.Name;
                }
            }
        }
        private void CleanviewFields()
        {
            view.Id = string.Empty;
            view.ProductId = string.Empty;
            view.PdName = string.Empty;
            view.Quantity = string.Empty;
            view.EntryDate = string.Empty;
            view.IsEdit = false;
        }

        #endregion


        #region Methods for Service and Validation Operations
        private async void SaveStock(object? sender, EventArgs e)
        {
            var stockModel = new Stock();
            stockModel.Id = string.IsNullOrEmpty(view.Id) ? 0 : int.Parse(view.Id);
            stockModel.ProductId = string.IsNullOrEmpty(view.ProductId) ? 0 : int.Parse(view.ProductId);
            stockModel.Product_Name = view.PdName;
            stockModel.Quantity = string.IsNullOrEmpty(view.Quantity) ? 0 : int.Parse(view.Quantity);
            stockModel.Entry_Date = string.IsNullOrEmpty(view.EntryDate) ? DateTime.Now : DateTime.Parse(view.EntryDate).Date;
            try
            {
                new ModelDataValidation().Valite(stockModel);
                try
                {
                    if (view.IsEdit)
                    {
                        await stockService.UpdateStock(stockModel);
                        view.Message = "Registro de estoque editado com sucesso.";
                    }
                    else
                    {
                        await stockService.AddStock(stockModel);
                        view.Message = "Registro de estoque adicionado com sucesso.";
                    }
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = $"Falha ao salvar o registro de estoque, com o seguinte erro: \n {ex.Message}";
                }

                view.IsSuccessful = true;
                CleanviewFields();
                LoadStockList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"Falha ao validar o registro de estoque: \n {ex.Message}";
            }
        }
        private async void DeleteSelectedStock(object? sender, EventArgs e)
        {
            var stockItem = (Stock)stockBindingSource.Current;
            if (stockItem != null)
            {
                try
                {
                    await stockService.DeleteStock(stockItem.Id);
                    view.Message = "Registro de estoque excluído com sucesso.";
                    view.IsSuccessful = true;
                    LoadStockList();
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = $"Falha ao excluir o registro de estoque, com o seguinte erro: \n {ex.Message}";
                }
            }
        }

        private async void SearchStock(object? sender, EventArgs e)
        {
            string searchTerm = view.SearchValue;
            bool EmptySearch = string.IsNullOrEmpty(searchTerm);
            if (!EmptySearch) stockList = int.TryParse(searchTerm, out int result)
                ? stockService.SearchStocksById(result)
                : stockService.SearchStocksByTerm(searchTerm);
            else stockList = await stockService.GetStocks();
            stockBindingSource.DataSource = stockList;
        }

        #endregion


        #region Interface Methods for Loading Data
        private async void LoadStockList()
        {
            try
            {
                stockList = await stockService.GetAllStocks();
                stockBindingSource.DataSource = null;
                stockBindingSource.DataSource = stockList.ToList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"Falha ao carregar a lista de estoque, com o seguinte erro: \n {ex.Message}";
            }
        }
        private void LoadSelectedProductList()
        {
            try
            {
                selectedProductList = productService.GetNamesFromCache();
                selectedProductBindingSource.DataSource = null;
                selectedProductBindingSource.DataSource = selectedProductList;
            }
            catch (Exception ex)
            {
                view.Message = $"Falha ao carregar a lista de produtos, com o seguinte erro: \n {ex.Message}";
                MessageBox.Show(view.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        // Singleton
        private static StockPresenter _instance;

        public static StockPresenter GetInstance(IStockView view, IProductService productService, IStockService stockService)
        {
            if (_instance == null)
            {
                _instance = new StockPresenter(view, productService, stockService);
            }
            else
            {
                (view as Form).MdiParent = (_instance.view as Form)?.MdiParent;
                _instance.CleanviewFields();
            }

            return _instance;
        }
    }
}
