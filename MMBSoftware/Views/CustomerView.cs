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
    public partial class CustomerView : Form, ICustomerView
    {
        // Fields
        private bool _isEdit;
        private bool _isSuccessful;
        private string _message;
        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabClientDetail);
            tabControl1.TabPages.Remove(tabClientAccount);
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Add
            btnAdd.Click += delegate
            {
                tabControl1.TabPages.Remove(tabClientList);
                tabControl1.TabPages.Add(tabClientDetail);
                checkBoxClientHaveAccount.Enabled = true;

                AddEvent?.Invoke(this, EventArgs.Empty);
                tabClientsDetailTitle.Text = "Adicionar novo Cliente";
            };

            // Edit
            btnEdit.Click += delegate
            {
                tabControl1.TabPages.Remove(tabClientList);
                tabControl1.TabPages.Add(tabClientDetail);

                cbDefineStateAccount.Enabled = true;
                labelCbDefineStateAccount.Enabled = true;
                txtDefineLimitAccount.Enabled = true;
                labelTxtDefineLimitAccount.Enabled = true;

                EditEvent?.Invoke(this, EventArgs.Empty);
                tabClientsDetailTitle.Text = "Editar Cliente";
            };

            // Cancel
            btnCancelEdit.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabClientDetail);
                tabControl1.TabPages.Add(tabClientList);

                defineStateFields();
            };

            // Save
            btnSaveEdit.Click += async delegate
            {
                btnSaveEdit.Enabled = false;
                SaveEvent?.Invoke(this, EventArgs.Empty);
                await Task.Delay(1000);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabClientDetail);
                    tabControl1.TabPages.Add(tabClientList);
                    MessageBox.Show(Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSaveEdit.Enabled = true;
                }
                else
                {
                    MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSaveEdit.Enabled = true;
                }

                defineStateFields();
            };

            btnSearch.Click += delegate{ SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchPd.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            btnDel.Click += async delegate
            {
                var result = MessageBox.Show("Você quer mesmo deletar este item?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                {
                    if(result == DialogResult.Yes)
                    {
                        try
                        {
                            DeleteEvent?.Invoke(this, EventArgs.Empty);

                            await Task.Delay(300);
                            if (IsSuccessful)
                            {
                                MessageBox.Show(Message, "Informação!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Falha ao excluir o registro do cliente, com o seguinte erro: \n {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ação cancelada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            };
        }

        // Properties
        public string CustomerId
        {
            get { return txtClientEditId.Text; }
            set 
            { 
                txtClientEditId.Text = value; 
            }
        }
        public string CustomerName 
        {
            get { return txtClientName.Text; }
            set
            {
                txtClientName.Text = value;
            }
        }
        public string CustomerEmail 
        {
            get { return txtClientEmail.Text; }
            set
            {
                txtClientEmail.Text = value;
            }
        }
        public string CustomerPhone
        {
            get { return txtMaskedClientPhone.Text; }
            set
            {
                txtMaskedClientPhone.Text = value;
            }
        }
        public string CustomerAddressCity
        {
            get { return txtClientAdressCity.Text; }
            set
            {
                txtClientAdressCity.Text = value;
            }
        }
        public string CustomerAddressDistrict
        {
            get { return txtClientAdressDistrict.Text; }
            set
            {
                txtClientAdressDistrict.Text = value;
            }
        }
        public string CustomerAddressStreet
        {
            get { return txtClientAdressStreet.Text; }
            set
            {
                txtClientAdressStreet.Text = value;
            }
        }
        public string CustomerAddressNumber
        {
            get { return txtClientAdressNumber.Text; }
            set
            {
                txtClientAdressNumber.Text = value;
            }
        }

        public bool CanPlaceOrder
        {
            get { return checkBoxClientHaveAccount.Checked; }
            set
            {
                checkBoxClientHaveAccount.Checked = value;
            }
        }

        public string CPF
        {
            get { return txtMaskedClientCpf.Text; }
            set { txtMaskedClientCpf.Text = value; }
        }

        public string StateAccount
        {
            get { return cbDefineStateAccount.Text; }
            set 
            {
                if (value != null)
                {
                    if(value == "True")
                    {
                        cbDefineStateAccount.SelectedIndex = cbDefineStateAccount.FindStringExact("Aberta");
                    }
                    else
                    {
                        cbDefineStateAccount.SelectedIndex = cbDefineStateAccount.FindStringExact("Fechada");
                    }
                }
            }
        }

        public bool HaveAdress
        {
            get { return checkBoxClientHaveAdress.Checked; }
            set
            {
                checkBoxClientHaveAdress.Checked = value;
            }
        }

        public string AccountLimit
        {
            get { return txtDefineLimitAccount.Text; }
            set
            {
                txtDefineLimitAccount.Text = value;
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
            set
            {
                _isEdit = value;
            }
        }

        public bool IsSuccessful
        {
            get { return _isSuccessful; }
            set
            {
                _isSuccessful = value;
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
            }
        }

        // Events
        public event EventHandler AddEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler SearchEvent;
        public event EventHandler DeleteEvent;

        // Methods
        public void setCustomerListBindingSource(BindingSource customerList)
        {
            dataGridClients.DataSource = customerList;
        }

        public void defineStateFields()
        {
            cbDefineStateAccount.Enabled = false;
            labelCbDefineStateAccount.Enabled = false;

            labelTxtDefineLimitAccount.Enabled = false;
            labelTxtDefineLimitAccount.Enabled = false;

            checkBoxClientHaveAccount.Enabled = false;
        }

        // Singleton
        private static CustomerView instance;
        public static CustomerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomerView();
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
