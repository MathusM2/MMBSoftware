using MMBSoftware.Models;
using MMBSoftware.Views;
using MMBSoftware.Repositories;
using MMBSoftware.Presenters;

namespace MMBSoftware
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string mySqlConnectionString = "Server=localhost;Port=3306;Database=mmbdb;Uid=root;Pwd=;";
            IMainView mainView = new MainView();
            MainPresenter mainPresenter = new MainPresenter(mainView, mySqlConnectionString);
            Application.Run((Form)mainView);
        }
    }
}