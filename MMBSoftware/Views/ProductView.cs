using MMBSoftware.Events;
using MMBSoftware.Views.Dialogs.CustomDialogs;
using MMBSoftware.Views.ViewInterfaces;
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
            ConfigureDataGridProduct();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabDetailPd);
        }

        private void AssociateAndRaiseViewEvents()
        {
            
            //Add
            btnAdd.Click += delegate { 
                tabControl1.TabPages.Remove(tabListPd);
                tabControl1.TabPages.Add(tabDetailPd);
                AddEvent?.Invoke(this, EventArgs.Empty);
                tabPdDetailTitle.Text = "Adicionar novo produto";
            };

            //Add Category
            cbFieldCategory.SelectedIndexChanged += delegate {
                if (cbFieldCategory.SelectedIndex == cbFieldCategory.Items.Count - 1)
                {
                    ProductCategoryDialogView dialog = new ProductCategoryDialogView(this);
                    dialog.ShowDialog();
                }
            };

            //Edit
            btnEdit.Click += delegate {
                tabControl1.TabPages.Remove(tabListPd);
                tabControl1.TabPages.Add(tabDetailPd);
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabPdDetailTitle.Text = "Detalhes do produto";
            };

            //Cancel
            btnDetailCancel.Click += delegate {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabDetailPd);
                tabControl1.TabPages.Add(tabListPd);
            };

            //Save
            btnDetailSave.Click += async delegate
            {
                btnDetailSave.Enabled = false;
                SaveEvent?.Invoke(this, EventArgs.Empty);
                await Task.Delay(1000);
                if(IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabDetailPd);
                    tabControl1.TabPages.Add(tabListPd);
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
                var result = MessageBox.Show("Você quer mesmo deletar este item?","Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteEvent?.Invoke(this, EventArgs.Empty);

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
                        MessageBox.Show($"Falha ao excluir o registro do item, com o seguinte erro: \n {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        public string Barcode
        {
            get { return txtFieldBarcode.Text; }
            set
            {
                txtFieldBarcode.Text = value;
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
            get { return cbFieldCategory.Text; }
            set
            {
                cbFieldCategory.SelectedIndex = cbFieldCategory.FindStringExact(value);
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
        public event EventHandler<StringEventArgs> AddCategory;

        // Methods
        public void SetProductListBindingSource(BindingSource productList)
        {
            dataGridViewProducts.DataSource = productList;
        }

        public void SetCategoryListBindingSource(BindingSource categoryList)
        {
            if(cbFieldCategory.DataSource != null) cbFieldCategory.DataSource = null; // Clear previous data source

            cbFieldCategory.DataSource = categoryList;
        }

        public void ProductEventNewCategory_Handler(string nameCategory)
        {
            AddCategory?.Invoke(this, new StringEventArgs(nameCategory));
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
