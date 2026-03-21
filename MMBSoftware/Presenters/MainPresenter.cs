using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MMBSoftware.Repositories;
using MMBSoftware.Services;
using MMBSoftware.Views;
using MMBSoftware.Views.ViewInterfaces;
using MySql.Data.MySqlClient;

namespace MMBSoftware.Presenters
{
    public class MainPresenter
    {
        //Fields
        private IMainView mainView;
        
        private ProductPresenter _productPresenter;
        private StockPresenter _stockPresenter;
        private CustomerPresenter _customerPresenter;
        private HomePresenter _homePresenter;

        private IProductService productService;
        private IStockService stockService;
        private ICustomerService customerService;

        public MainPresenter(IMainView mainView, IProductService productService, IStockService stockService, ICustomerService customerService)
        {
            this.mainView = mainView;

            this.productService = productService;
            this.stockService = stockService;
            this.customerService = customerService;
            

            this.mainView.ShowHomeView += ShowHomeView;
            this.mainView.ShowProductView += ShowProductView;
            this.mainView.ShowStockView += ShowStockView;
            this.mainView.ShowCustomerView += ShowCustomerView;
            this.mainView.CloseMainView += CloseMainView;

        }

        //Methods
        #region Methods

        #region Show Views
        private async void ShowHomeView(object? sender, EventArgs e)
        {
            try
            {
                IHomeView homeView = HomeView.GetInstance((MainView)mainView);
                IHomeService homeService = new HomeService();
                _homePresenter = HomePresenter.GetInstance(homeView, homeService);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar a aba dos produtos!\nCom o seguinte erro:\n{ex.Message}");
            }
        }

        private async void ShowProductView(object? sender, EventArgs e)
        {
            try
            {
                IProductView productView = ProductView.GetInstance((MainView)mainView);
                _productPresenter = ProductPresenter.GetInstance(productView, productService);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar a aba dos produtos!\nCom o seguinte erro:\n{ex.Message}");
            }
        }

        private async void ShowStockView(object? sender, EventArgs e)
        {
            try
            {
                IStockView stockView = StockView.GetInstance((MainView)mainView);
                _stockPresenter = StockPresenter.GetInstance(stockView, productService, stockService);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar a aba do estoque!\nCom o seguinte erro:\n{ex.Message}");
            }
        }

        private async void ShowCustomerView(object? sender, EventArgs e)
        {
            ICustomerView customerView = CustomerView.GetInstance((MainView)mainView);

            try
            {
                await customerService.InitiaInitializeAsync();
                _customerPresenter = new CustomerPresenter(customerView, customerService);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar a aba dos clientes!\nCom o seguinte erro:\n{ex.Message}");
            }
        }

        private void CloseMainView(object? sender, EventArgs E)
        {
            (mainView as Form).Dispose();
        }
        #endregion
        #endregion
    }
}
