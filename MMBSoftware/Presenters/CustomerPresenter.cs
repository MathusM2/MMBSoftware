using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Models;
using MMBSoftware.Presenters.Commom;
using MMBSoftware.Services;
using MMBSoftware.Views.ViewInterfaces;

namespace MMBSoftware.Presenters
{
    public class CustomerPresenter
    {
        // Fields
        private readonly ICustomerView view;
        private readonly ICustomerService service;
        private BindingSource customerBindingSource;
        private IEnumerable<Customer> customerList;

        // Constructor
        public CustomerPresenter(ICustomerView view, ICustomerService service)
        {
            customerBindingSource = new BindingSource();
            this.view = view;
            this.service = service;
            //Subscribe to view events
            this.view.AddEvent += AddNewCustomer;
            this.view.EditEvent += SelectedCustomerAction;
            this.view.DeleteEvent += DeleteItemAction;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;
            this.view.SearchEvent += SearchCustomer;
            // Set customer list binding source
            this.view.setCustomerListBindingSource(customerBindingSource);
            // Show the view
            this.view.Show();
            // Load customer list
            LoadCustomerList();
        }


        // Methods
        #region Methods for UI
        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void SelectedCustomerAction(object? sender, EventArgs e)
        {

            var selectedItem = (Customer)customerBindingSource.Current;
            var address = Adress.ConvertToAddress(selectedItem.Address);
            if (selectedItem != null)
            {
                view.CustomerId = selectedItem.Id.ToString();
                view.CustomerName = selectedItem.Name;
                view.CustomerEmail = selectedItem.Email;
                view.CustomerPhone = selectedItem.Phone;
                view.CustomerAddressCity = address.City;
                view.CustomerAddressDistrict = address.District;
                view.CustomerAddressStreet = address.Street;
                view.CustomerAddressNumber = address.Number;
                view.StateAccount = selectedItem.CanPlaceOrder.ToString();
                view.AccountLimit = selectedItem.AccountLimit.ToString();
                view.CPF = selectedItem.CPF;

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
            view.CustomerId = string.Empty;
            view.CustomerName = string.Empty;
            view.CustomerEmail = string.Empty;
            view.CustomerPhone = string.Empty;
            view.CustomerAddressCity = string.Empty;
            view.CustomerAddressDistrict = string.Empty;
            view.CustomerAddressStreet = string.Empty;
            view.CustomerAddressNumber = string.Empty;
            view.CanPlaceOrder = false;
            view.AccountLimit = string.Empty;
            view.StateAccount = "false";
            view.CPF = string.Empty;
        }
        #endregion


        #region Methods for Service and Validation Operations
        private async void SaveCustomer(object? sender, EventArgs e)
        {
            int id = int.TryParse(view.CustomerId, out int idResult) ? idResult : 0;
            string name = view.CustomerName;
            string email = view.CustomerEmail;
            string phone = view.CustomerPhone;
            string adress = new Adress(string.Empty, view.CustomerAddressCity, view.CustomerAddressDistrict, view.CustomerAddressStreet, view.CustomerAddressNumber).ToString();
            bool stateAccount = view.StateAccount == "Aberta" ? true : false;
            bool canPlaceOrder = view.CanPlaceOrder;
            string accountLimit = view.AccountLimit;
            string cpf = view.CPF;

            Customer customerModel = new Customer();
            customerModel.Id = id;
            customerModel.Name = name;
            customerModel.Email = email;
            customerModel.Phone = phone;
            customerModel.Address = adress;
            customerModel.AccountLimit = int.TryParse(accountLimit, out int accountResult) ? accountResult : 0;
            customerModel.CPF = cpf;
            if (view.IsEdit)
                customerModel.CanPlaceOrder = stateAccount;
            else
                customerModel.CanPlaceOrder = canPlaceOrder;


                try
                {
                    new ModelDataValidation().Valite(customerModel);
                    try
                    {
                        if (view.IsEdit)
                        {
                            await service.UpdateCustomer(customerModel);
                            view.Message = "Registro de estoque editado com sucesso.";
                            view.IsSuccessful = true;
                        }
                        else
                        {
                            await service.AddCustomer(customerModel);
                            view.Message = "Registro de estoque adicionado com sucesso.";
                            view.IsSuccessful = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        view.IsSuccessful = false;
                        view.Message = $"Falha ao salvar o registro de produto, com o seguinte erro:\n {ex.Message}";
                    }
                    CleanviewFields();
                    LoadCustomerList();
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = $"Falha ao validar:\n {ex.Message}";
                }
        }
        private async void DeleteItemAction(object? sender, EventArgs e)
        {
            var selectedItem = (Customer)customerBindingSource.Current;
            if (selectedItem != null)
            {
                try
                {
                    await service.DeleteCustomer(selectedItem.Id);
                    view.Message = "Registro do cliente excluido com sucesso.";
                    view.IsSuccessful = true;
                    LoadCustomerList();
                }
                catch (Exception ex)
                {
                    view.IsSuccessful = false;
                    view.Message = $"Falha ao excluir o registro do cliente, com o seguinte erro: \n {ex.Message}";
                }
            }
        }

        private async void SearchCustomer(object? sender, EventArgs e)
        {
            string searchTerm = view.SearchValue;
            bool EmptySearch = string.IsNullOrEmpty(searchTerm);
            if (!EmptySearch) customerList = int.TryParse(searchTerm, out int result)
                ? service.SearchCustomersById(result)
                : service.SearchCustomersByTerm(searchTerm);
            else customerList = await service.GetCustomers();
            customerBindingSource.DataSource = customerList;
        }
        #endregion

        #region Interface Methods for Loading Data
        private async void LoadCustomerList()
        {
            try
            {
                customerList = await service.GetAllCustomers();
                customerBindingSource.DataSource = null;
                customerBindingSource.DataSource = customerList;
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Falha ao carregar a lista de clientes, com o seguinte erro: /n " + ex.Message + "/n" + ex.StackTrace;
            }
        }
        #endregion

        //Singleton
        private static CustomerPresenter _instance;

        public static CustomerPresenter GetInstance(ICustomerView view, ICustomerService service)
        {
            if (_instance == null)
            {
                _instance = new CustomerPresenter(view, service);
            }
            else
            {
                (view as Form).MdiParent = (_instance.view as Form).MdiParent;
            }
            return _instance;
        }
    }
}
