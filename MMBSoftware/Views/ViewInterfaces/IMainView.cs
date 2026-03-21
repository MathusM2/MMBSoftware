using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Views.ViewInterfaces
{
    public interface IMainView
    {
        event EventHandler ShowHomeView;
        event EventHandler ShowProductView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowStockView;
        event EventHandler ShowCustomerView;
        event EventHandler CloseMainView;
    }
}
