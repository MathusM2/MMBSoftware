using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Events;
using MMBSoftware.Models;
using MMBSoftware.Presenters.Commom;
using MMBSoftware.Services;
using MMBSoftware.Views;

namespace MMBSoftware.Presenters
{
    public class ProductPresenter
    {
        // Fields
        private IProductView view;
        private IProductService serviceProduct;
        private BindingSource productBindingSource;
        private BindingSource categoryBindingSource;
        private IEnumerable<Product> productList;
        private IEnumerable<string> categoryList;

        // Constructor
        public ProductPresenter(IProductView view, IProductService serviceProduct)
        {
            this.productBindingSource = new BindingSource();
            this.categoryBindingSource = new BindingSource();
            this.view = view;
            this.serviceProduct = serviceProduct;
            // Subscribe to view events
            this.view.SearchEvent += SearchProduct;
            this.view.AddEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;
            this.view.AddCategory += AddCategory;
            // Set product list binding source
            this.view.SetProductListBindingSource(productBindingSource);
            this.view.SetCategoryListBindingSource(categoryBindingSource);
            // Show the view
            this.view.Show();
            // Load product list
            LoadProductList();
        }

        //Methods
        #region Methods for UI
        private async void AddNewProduct(object? sender, EventArgs e)
        {
            await Task.Delay(500);
            view.IsEdit = false;
            LoadCategoriesList();
        }
        private async void AddCategory(object? sender, StringEventArgs e)
        {
            List<string> modList = categoryList.ToList();
            modList.Remove(modList.Last());
            modList.Add($"{e._value}");
            modList.Add("Nova categoria");
            categoryList = modList;
            categoryBindingSource.DataSource = null;
            categoryBindingSource.DataSource = categoryList;
        }

        private void LoadSelectedProductEdit(object? sender, EventArgs e)
        {
            LoadCategoriesList();
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
        private void CancelAction(object? sender, EventArgs e)
        {
            CleanviewFields();
            view.IsEdit = false;
        }


        private void CleanviewFields()
        {
            view.ProductId = string.Empty;
            view.PdName = string.Empty;
            view.Description = string.Empty;
            view.Price = string.Empty;
            view.Category = string.Empty;
            LoadProductList();
            LoadCategoriesList();
        }

        #endregion


        #region Methods for Service and Validation Operations

        private async void SaveProduct(object? sender, EventArgs e)
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
                try
                {
                    if (view.IsEdit)
                    {
                        await serviceProduct.UpdateProduct(productModel);
                        view.Message = "Produto atualizado com sucesso!";
                    }
                    else
                    {
                        await serviceProduct.CreateProduct(productModel);
                        view.Message = "Produto adicionado com sucesso!";
                    }
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = $"Falha ao salvar o registro de produto, com o seguinte erro:\n {ex.Message}";
                }

                view.IsSuccessful = true;

                
                CleanviewFields();
                LoadProductList();

                await Task.Delay(500);
                RefeshStockView?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"Falha ao validar:\n {ex.Message}";
            }
        }
        
        private async void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            Product productModel = (Product)productBindingSource.Current;
            if (productModel != null)
            {
                try
                {
                    await serviceProduct.DeleteProduct(productModel.Id);
                    view.Message = "Registro de produto excluido com sucesso.!";
                    view.IsSuccessful = true;
                    LoadProductList();
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = $"Falha ao excluir o registro do item, com o seguinte erro: \n {ex.Message}";
                }
            }
        }
        private async void SearchProduct(object? sender, EventArgs e)
        {
            string searchValue = view.SearchValue;
            bool EmptySearch = string.IsNullOrEmpty(view.SearchValue);
            if (!EmptySearch) productList = int.TryParse(searchValue, out int productId)
                ? serviceProduct.SearchProductsById(productId)
                : serviceProduct.SearchProductsByTerm(searchValue);
            else productList = await serviceProduct.GetAllProducts();
            productBindingSource.DataSource = productList.ToList(); // Update the binding source
        }

        #endregion


        #region Interface Methods for Loading Data

        private async void LoadProductList()
        {
            try
            {
                productList = await serviceProduct.GetAllProducts();
                productBindingSource.DataSource = null;
                productBindingSource.DataSource = productList.ToList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"Erro ao carregar a lista:\n {ex.Message}";
            }
        }

        private void LoadCategoriesList()
        {
            try
            {
                categoryList = productList.Select(p => p.Category).Distinct().Append("Selecione uma categoria").Reverse().Append("Nova categoria");
                categoryBindingSource.DataSource = null;
                categoryBindingSource.DataSource = categoryList;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = $"Erro ao carregar a lista de categorias:\n {ex.Message}";
                MessageBox.Show(view.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        // Singleton
        private static ProductPresenter _instance;

        public static ProductPresenter GetInstance(IProductView view, IProductService productService)
        {
            if (_instance == null)
            {
                _instance = new ProductPresenter(view, productService);
            }
            else
            {
                (view as Form).MdiParent = (_instance.view as Form)?.MdiParent;
            }

            return _instance;
        }

        // Events
        public event EventHandler RefeshStockView;
    }
}

