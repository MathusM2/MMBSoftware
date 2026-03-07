using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MMBSoftware.Models;
using MMBSoftware.Models.Enums;
using MMBSoftware.Services;

namespace MMBSoftware.Views.Dialogs
{
    public partial class StockFilterDialogView : Form
    {
        private IStockView _stockView;
        private IFilter _filter;
        public StockFilterDialogView(IStockView view, IFilter oldFilter)
        {
            InitializeComponent();
            _stockView = view;
            _filter = oldFilter;
            RestoreStockFilterSettings();
        }

        private void RestoreStockFilterSettings()
        {
            if(_filter != null)
            {
                if (_filter.ExpirationFilter == null)
                    clbFilterExpiration.ClearSelected();
                else if (_filter.ExpirationFilter.Value == true)
                    clbFilterExpiration.SetItemChecked(0, true);
                else 
                    clbFilterExpiration.SetItemChecked(1, true);


                if (_filter.SituationFilter == null)
                    clbFilterSituation.ClearSelected();
                else if (_filter.SituationFilter.Value == true)
                    clbFilterSituation.SetItemChecked(0, true);
                else
                    clbFilterSituation.SetItemChecked(1, true);


                if (_filter.UnitType == null)
                    clbFilterUnitType.ClearSelected();
                else if (_filter.UnitType == UnitType.Unit)
                    clbFilterUnitType.SetItemChecked(0, true);
                else if (_filter.UnitType == UnitType.Box)
                    clbFilterUnitType.SetItemChecked(1, true);
                else
                    clbFilterUnitType.SetItemChecked(2, true);
            }
        }

        public event EventHandler FilterEvent;


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CheckedListBox statusFilter = clbFilterSituation;
            CheckedListBox expirationFilter = clbFilterExpiration;
            CheckedListBox unitTypeFilter = clbFilterUnitType;
            bool? expFilter = clbFilterExpiration.CheckedItems.Count > 0 ? (expirationFilter.SelectedIndex == 0 ? true : false) : null;
            bool? stFilter = clbFilterSituation.CheckedItems.Count > 0 ? (statusFilter.SelectedIndex == 0 ? true : false) : null;
            UnitType? unitType = clbFilterUnitType.CheckedItems.Count > 0 ? (unitTypeFilter.SelectedItem.ToString() == "Caixa" ? UnitType.Box : unitTypeFilter.SelectedItem.ToString() == "Pacote" ? UnitType.Package : UnitType.Unit) : null;
            _filter = new Filter(expFilter, stFilter, unitType);

            _stockView.FilterStockEvent_Handler(_filter);
            this.Close();
        }

        private void clbFilterUnitType_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox unitFilterBox = (CheckedListBox)sender;
            if (unitFilterBox.CheckedItems.Count > 0)
            {
                CheckedListBox.CheckedItemCollection checkedItems = unitFilterBox.CheckedItems;
                checkedItems.Cast<object>().ToList().ForEach(item =>
                {
                    if (item.ToString() != unitFilterBox.Items[e.Index].ToString())
                    {
                        int itemIndex = unitFilterBox.Items.IndexOf(item);
                        unitFilterBox.SetItemChecked(itemIndex, false);
                    }
                });
            }
        }

        private void clbFilterExpiration_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox expFilterBox = (CheckedListBox)sender;
            if (expFilterBox.CheckedItems.Count > 0)
            {
                CheckedListBox.CheckedItemCollection checkedItems = expFilterBox.CheckedItems;
                checkedItems.Cast<object>().ToList().ForEach(item =>
                {
                    if (item.ToString() != expFilterBox.Items[e.Index].ToString())
                    {
                        int itemIndex = expFilterBox.Items.IndexOf(item);
                        expFilterBox.SetItemChecked(itemIndex, false);
                    }
                });
            }
        }

        private void clbFilterSituation_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox situationFilterBox = (CheckedListBox)sender;
            if (situationFilterBox.CheckedItems.Count > 0)
            {
                CheckedListBox.CheckedItemCollection checkedItems = situationFilterBox.CheckedItems;
                checkedItems.Cast<object>().ToList().ForEach(item =>
                {
                    if (item.ToString() != situationFilterBox.Items[e.Index].ToString())
                    {
                        int itemIndex = situationFilterBox.Items.IndexOf(item);
                        situationFilterBox.SetItemChecked(itemIndex, false);
                    }
                });
            }
        }
    }
}
