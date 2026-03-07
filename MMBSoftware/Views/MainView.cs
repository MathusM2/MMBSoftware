using MMBSoftware.Views;

namespace MMBSoftware
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            sbBtnHome.Click += delegate { ShowHomeView?.Invoke(this, EventArgs.Empty); };
            sbBtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
            sbBtnStock.Click += delegate { ShowStockView?.Invoke(this, EventArgs.Empty); };
            sbBtnClients.Click += delegate { ShowCustomerView?.Invoke(this, EventArgs.Empty); };
            sbBtnLeave.Click += delegate { CloseMainView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowHomeView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowStockView;
        public event EventHandler ShowCustomerView;
        public event EventHandler CloseMainView;

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            if (sideBarPanel.Visible)
                sideBarPanel.Visible = false;
            else sideBarPanel.Visible = true;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account");
        }
    }
}
