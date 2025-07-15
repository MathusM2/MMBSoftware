using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMBSoftware.Views
{
    public partial class ProductView : Form, IProductView
    {
        // Fields
        private bool _isEdit;
        private bool _isSuccessful;
        private string _message;

        // Constructor
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabDetailPd);
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchPd.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            // Others
        }

        // Properties
        public string ProductId 
        {
            get { return txtFieldId.Text; }
            set
            {
                txtFieldId.Text = value;
            }
        }
        public string Description 
        { 
            get { return txtFieldDescription.Text; }
            set
            {
                txtFieldDescription.Text = value;
            }
        }
        public string Price 
        { 
            get { return txtFieldPrice.Text; }
            set
            {
                txtFieldPrice.Text = value;
            }
        }
        public string Category 
        { 
            get { return txtFieldCategory.Text; }
            set
            {
                txtFieldCategory.Text = value;
            }
        }
        public string SearchValue 
        {
            get { return txtSearchPd.Text; }
            set 
            { 
                txtSearchPd.Text = value; 
            }
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

        // Events
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SearchEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods
        public void SetProductListBindingSource(BindingSource productList)
        {
            dataGridViewProducts.DataSource = productList;
        }

        // Singleton

        private static ProductView instance;
        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
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
    }
}
