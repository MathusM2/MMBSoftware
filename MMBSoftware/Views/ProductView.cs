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
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchPd.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Add
            btnAdd.Click += delegate { 
                AddEvent?.Invoke(this, EventArgs.Empty);  
                tabControl1.TabPages.Remove(tabListPd);
                tabControl1.TabPages.Add(tabDetailPd);
                tabPdDetailTitle.Text = "Add New Product";
            };
            //Edit
            btnEdit.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabListPd);
                tabControl1.TabPages.Add(tabDetailPd);
                tabPdDetailTitle.Text = "Edit Product";
            };
            //Save
            btnDetailSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if(IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabDetailPd);
                    tabControl1.TabPages.Add(tabListPd);
                    //Adicionar logica de validação e sucesso
                }
            };
            //Cancel
            btnDetailCancel.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabDetailPd);
                tabControl1.TabPages.Add(tabListPd);
            };
            //Delete
            btnDel.Click += delegate {
                var result = MessageBox.Show("Você quer mesmo deletar este item?","Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    //Adicionar Logica de resultado
                }
                else
                {
                    MessageBox.Show("Ação cancelada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
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
        public string PdName
        {
            get { return txtFieldName.Text; }
            set
            {
                txtFieldName.Text = value;
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
