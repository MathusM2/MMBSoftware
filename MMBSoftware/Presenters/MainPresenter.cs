using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MMBSoftware.Repositories;
using MMBSoftware.Views;
using MySql.Data.MySqlClient;

namespace MMBSoftware.Presenters
{
    public class MainPresenter
    {
        //Fields
        private IMainView mainView;
        private string mySqlConnection;

        public MainPresenter(IMainView mainView, string mySqlConnection)
        {
            this.mainView = mainView;
            this.mySqlConnection = mySqlConnection;
            this.mainView.ShowProductView += ShowProductView;
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView productView = ProductView.GetInstance((MainView)mainView);
            IProductRepository productRepository = new ProductRepository(this.mySqlConnection);
            new ProductPresenter(productView, productRepository);
        }
    }
}
