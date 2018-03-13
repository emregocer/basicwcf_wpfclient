using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WcfTest3.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }

        void App_Startup(object sender, StartupEventArgs e)
        {
            ApplicationView app = new ApplicationView();
            var context = SimpleIoc.Default.GetInstance<AppViewModel>();
            app.DataContext = context;
            app.Show();
        }

    }
}
