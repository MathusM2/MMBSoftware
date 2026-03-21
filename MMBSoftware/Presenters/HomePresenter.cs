using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMBSoftware.Services;
using MMBSoftware.Views.ViewInterfaces;

namespace MMBSoftware.Presenters
{
    public class HomePresenter
    {
        private readonly IHomeView view;
        private IHomeService service;

        // Constructor
        public HomePresenter (IHomeView view, IHomeService service)
        {
            this.view = view;
            this.service = service;

            // Show the View
            this.view.Show();
        }

        // Singleton
        private static HomePresenter _instance;
        public static HomePresenter GetInstance(IHomeView view, IHomeService service)
        {
            if(_instance == null)
            {
                _instance = new HomePresenter(view, service);
            }
            else
            {
                (view as Form).MdiParent = (_instance.view as Form)?.MdiParent;
            }
            return _instance;
        }
    }
}
