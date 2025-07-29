using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MMBSoftware.Repositories;
using MMBSoftware.Services;
using MMBSoftware.Views;
using MySql.Data.MySqlClient;

namespace MMBSoftware.Presenters
{
    public class MainPresenter
    {
        //Fields
        private IMainView mainView;
        private IProductRepository productRepository;
        private IStockRepository stockRepository;

        private string mySqlConnection;
        private ProductPresenter _productPresenter;
        private StockPresenter _stockPresenter;

        public MainPresenter(IMainView mainView, string mySqlConnection)
        {
            this.mainView = mainView;
            this.mySqlConnection = mySqlConnection;

            this.productRepository = new ProductRepository(this.mySqlConnection);
            this.stockRepository = new StockRepository(this.mySqlConnection);

            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowStockView += ShowStockView;
        }

        private async void ShowProductView(object? sender, EventArgs e)
        {
            IProductView productView = ProductView.GetInstance((MainView)mainView);
            IProductService productService = new ProductService(productRepository);

            await productService.InitiaInitializeAsync();
            _productPresenter = ProductPresenter.GetInstance(productView, productService);
        }

        private async void ShowStockView(object? sender, EventArgs e)
        {
            IStockView stockView = StockView.GetInstance((MainView)mainView);
            IProductService productService = new ProductService(productRepository);
            IStockService stockService = new StockService(stockRepository);
            
            await productService.InitiaInitializeAsync();
            _stockPresenter = StockPresenter.GetInstance(stockView, productService, stockService);
        }
    }
}
