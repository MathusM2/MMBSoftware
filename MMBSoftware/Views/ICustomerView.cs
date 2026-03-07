using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Views
{
    public interface ICustomerView
    {
        string CustomerId { get; set; }
        string CustomerName { get; set; }
        string CustomerEmail { get; set; }
        string CustomerPhone { get; set; }
        string CustomerAddressCity { get; set; }
        string CustomerAddressDistrict { get; set; }
        string CustomerAddressStreet { get; set; }
        string CustomerAddressNumber { get; set; }
        bool CanPlaceOrder { get; set; }
        string StateAccount { get; set; }
        string CPF {  get; set; }
        string AccountLimit { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler SearchEvent;
        event EventHandler DeleteEvent;

        void setCustomerListBindingSource(BindingSource customerList);
        void Show();
    }
}
