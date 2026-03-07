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
    public partial class HomeView : Form, IHomeView
    {
        public HomeView()
        {
            InitializeComponent();
        }

        // Singleton
        private static HomeView instance;
        public static HomeView GetInstance(Form parentContainer)
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new HomeView();
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
