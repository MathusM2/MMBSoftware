using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MMBSoftware.Views;

namespace MMBSoftware.Presenters
{
    public class ProductPresenter
    {
        // Fields
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<Product> productList;

        // Constructor
        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            // Subscribe to view events
            this.view.SearchEvent += SearchProduct;
            this.view.AddEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;
            // Set product list binding source
            this.view.SetProductListBindingSource(productBindingSource);
            // Load product list
            LoadProductList();
            // Show the view
            this.view.Show();
        }

        // Methods
        private void LoadProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList.ToList();// Set source for the binding
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool EmptySearch = string.IsNullOrEmpty(view.SearchValue);
            if (!EmptySearch) productList = repository.GetByValue(this.view.SearchValue);
            else productList = repository.GetAll();
            productBindingSource.DataSource = productList.ToList(); // Update the binding source
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedProductEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
