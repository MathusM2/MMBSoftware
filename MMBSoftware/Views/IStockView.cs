using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Views
{
    public interface IStockView
    {
        string Id { get; set; }
        string SelectedProduct { get; set; }
        string ProductId { get; set; }
        string PdName { get; set; }
        string Quantity { get; set; }
        string EntryDate { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler AddEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler SelectedProductEvent;
        event EventHandler CancelEvent;
        event EventHandler SearchEvent;
        event EventHandler DeleteEvent;

        void setStockListBindingSource(BindingSource stockList);
        void setSelectedProductListBindingSource(BindingSource selectedProductList);
        void Show();
    }
}
