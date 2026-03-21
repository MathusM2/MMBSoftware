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
using MMBSoftware.Views.Dialogs;
using MMBSoftware.Views.ViewInterfaces;

namespace MMBSoftware.Views
{
    public partial class StockView : Form, IStockView
    {

        // Fields
        private bool _isEdit;
        private bool _isSuccessful;
        private string _message;
        private IFilter _filter { get; set; }

        //Constructor
        public StockView()
        {
            InitializeComponent();
            ConfigureDataGridStock();
            AssociateAndRaiseViewEvents();
            tabStockEdit.TabPages.Remove(tabStockRegEdit);
            cbFieldTypeUnit.DataSource = UnitTypeToStringExtensions.GetAllUnitTypes();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Add
            btnAdd.Click += delegate
            {
                tabStockEdit.TabPages.Remove(tabStockList);
                tabStockEdit.TabPages.Add(tabStockRegEdit);
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabPdDetailTitle.Text = "Add New Stock registration";
            };
            //Edit
            btnEdit.Click += delegate
            {
                tabStockEdit.TabPages.Remove(tabStockList);
                tabStockEdit.TabPages.Add(tabStockRegEdit);
                cbFieldProduct.MouseDown += (s, e) =>
                {
                    if (IsEdit)
                        ((ComboBox)s).DroppedDown = false;
                    else
                        ((ComboBox)s).DroppedDown = true;
                };
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabPdDetailTitle.Text = "Edit Stock Product";
            };

            //Cancel
            btnDetailCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabStockEdit.TabPages.Remove(tabStockRegEdit);
                tabStockEdit.TabPages.Add(tabStockList);
            };

            //Selected Product
            cbFieldProduct.SelectedIndexChanged += (s, e) =>
            {
                SelectedProductEvent?.Invoke(s, e);
            };

            //Save
            btnDetailSave.Click += async delegate
            {
                btnDetailSave.Enabled = false;
                SaveEvent?.Invoke(this, EventArgs.Empty);
                await Task.Delay(300);
                if (IsSuccessful)
                {
                    tabStockEdit.TabPages.Remove(tabStockRegEdit);
                    tabStockEdit.TabPages.Add(tabStockList);
                    MessageBox.Show(Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDetailSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDetailSave.Enabled = true;
                }
            };

            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchPd.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            //Delete
            btnDel.Click += async delegate
            {
                var result = MessageBox.Show("Você quer mesmo deletar este item?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteEvent.Invoke(this, EventArgs.Empty);

                        await Task.Delay(300);
                        if (IsSuccessful)
                        {
                            MessageBox.Show(Message, "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao deletar o item: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ação cancelada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
        }

        // Properties
        public string StockId
        {
            get { return txtFieldId.Text; }
            set { txtFieldId.Text = value; }
        }
        public string SelectedProduct
        {
            get { return cbFieldProduct.Text; }
            set
            {
                cbFieldProduct.SelectedIndex = cbFieldProduct.FindStringExact(value);
            }
        }
        public string ProductId
        {
            get { return FieldPd_Id.Text; }
            set { FieldPd_Id.Text = value; }
        }
        public string PdName
        {
            get { return FieldPd_Name.Text; }
            set { FieldPd_Name.Text = value; }
        }
        public string Quantity
        {
            get { return txtFieldQuantity.Text; }
            set { txtFieldQuantity.Text = value; }
        }

        public string UnitType
        {
            get { return cbFieldTypeUnit.Text; }
            set
            {
                cbFieldTypeUnit.Text = value;
            }
        }

        public string EntryDate
        {
            get { return txtFieldEntryDate.Text; }
            set
            {
                txtFieldEntryDate.Text = value;
            }
        }
        public string ExpiryDate
        {
            get { return txtFieldExpiryDate.Text; }
            set
            {
                txtFieldExpiryDate.Text = value;
            }
        }
        public string SearchValue
        {
            get { return txtSearchPd.Text; }
            set { txtSearchPd.Text = value; }
        }
        public bool IsEdit
        {
            get { return _isEdit; }
            set { _isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public IFilter StockFilter
        {
            get { return _filter; }
            set { _filter = value; }
        }

        //Events

        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SelectedProductEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler SearchEvent;
        public event EventHandler FilterEvent;


        // Methods
        public void setStockListBindingSource(BindingSource stockList)
        {
            dataGridStockList.DataSource = stockList;
        }

        public void FilterStockEvent_Handler(IFilter filter)
        {
            _filter = filter;
            FilterEvent?.Invoke(this, EventArgs.Empty);

        }

        public void setSelectedProductListBindingSource(BindingSource selectedProductList)
        {
            cbFieldProduct.DataSource = selectedProductList;
        }

        // Singleton
        private static StockView instance;

        public static StockView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StockView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                else
                    instance.BringToFront();
            }
            return instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockFilterDialogView viewDialog = new StockFilterDialogView(this, _filter);
            viewDialog.StartPosition = FormStartPosition.CenterParent;
            viewDialog.ShowDialog();
        }

        private void btnResetList_Click(object sender, EventArgs e)
        {
            SearchEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
