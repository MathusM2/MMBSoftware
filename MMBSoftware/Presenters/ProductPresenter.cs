using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MMBSoftware.Presenters.Commom;
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
        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false; // Set the view to add mode
        }
        private void LoadSelectedProductEdit(object? sender, EventArgs e)
        {
            var productItem = (Product)productBindingSource.Current;
            if (productItem != null)
            {
                view.ProductId = productItem.Id.ToString();
                view.PdName = productItem.Name;
                view.Description = productItem.Description;
                view.Price = productItem.Price.ToString();
                view.Category = productItem.Category;
                view.IsEdit = true;
            }
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            Product productModel = new Product();
            productModel.Id = int.TryParse(view.ProductId, out int id) ? id : 0;
            productModel.Name = view.PdName;
            productModel.Description = view.Description;
            productModel.Category = view.Category;
            productModel.Price = decimal.TryParse(view.Price, out decimal price) ? price : 0;

            try
            {
                new ModelDataValidation().Valite(productModel);
                if (view.IsEdit)
                {
                    repository.UpdateProduct(productModel);
                    view.Message = "Product edited successfuly.";
                }
                else
                {
                    repository.AddProduct(productModel);
                    view.Message = "Product added successfully.";
                }
                view.IsSuccessful = true;
                LoadProductList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"Error saving product: {ex.Message}";
                MessageBox.Show(view.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
            view.IsEdit = false; // Reset the edit mode
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            Product productModel = (Product)productBindingSource.Current;
            try
            {
                repository.DeleteProduct(productModel.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                LoadProductList();
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"Error deleting product: {ex.Message}";
                MessageBox.Show(view.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CleanviewFields()
        {
            view.ProductId = string.Empty;
            view.PdName = string.Empty;
            view.Description = string.Empty;
            view.Price = string.Empty;
            view.Category = string.Empty;
        }
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
    }
}
