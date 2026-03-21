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

namespace MMBSoftware.Views.Dialogs.CustomDialogs
{
    public partial class ProductCategoryDialogView : Form
    {
        IProductView _productView;
        public ProductCategoryDialogView(IProductView productView)
        {
            InitializeComponent();
            _productView = productView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productView.ProductEventNewCategory_Handler(textBox1.Text);
            this.Close();
        }
    }
}
