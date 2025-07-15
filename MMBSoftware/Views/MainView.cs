using MMBSoftware.Views;

namespace MMBSoftware
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            sbBtnProduct.Click += delegate { ShowProductView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowProductView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowStockView;
    }
}
