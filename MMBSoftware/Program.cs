using MMBSoftware.Models;
using MMBSoftware.Views;
using MMBSoftware.Repositories;
using MMBSoftware.Presenters;
using MMBSoftware.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace MMBSoftware
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string mySqlConnectionString = "Server=localhost;Port=3306;Database=mmdb;Uid=root;Pwd=;";

            var services = new ServiceCollection();
            // Register repositories
            services.AddSingleton<IProductRepository>(new ProductRepository(mySqlConnectionString));
            services.AddSingleton<IStockRepository>(new StockRepository(mySqlConnectionString));
            services.AddSingleton<ICustomerRepository>(new CustomerRepository(mySqlConnectionString));

            // Resolve repositories
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<IStockService, StockService>();
            services.AddSingleton<ICustomerService, CustomerService>();

            var serviceProvider = services.BuildServiceProvider();
            var productService = serviceProvider.GetRequiredService<IProductService>();
            var stockService = serviceProvider.GetRequiredService<IStockService>();
            var customerService = serviceProvider.GetRequiredService<ICustomerService>();
            
            productService.InitiaInitializeAsync().GetAwaiter().GetResult();
            stockService.InitiaInitializeAsync().GetAwaiter().GetResult();
            customerService.InitiaInitializeAsync().GetAwaiter().GetResult();

            IMainView mainView = new MainView();
            MainPresenter mainPresenter = new MainPresenter(mainView, productService, stockService, customerService);
            Application.Run((Form)mainView);
        }
    }
}