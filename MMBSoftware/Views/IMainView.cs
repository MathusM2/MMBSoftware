using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Views
{
    public interface IMainView
    {
        event EventHandler ShowProductView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowStockView;
    }
}
