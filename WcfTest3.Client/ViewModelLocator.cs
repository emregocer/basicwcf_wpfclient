using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Client.Helpers;

namespace WcfTest3.Client
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<AppViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<PanelViewModel>();
            SimpleIoc.Default.Register<CategoryViewModel>();
            SimpleIoc.Default.Register<DataService>();
        }

        public AppViewModel AppViewModel
        {
            get { return SimpleIoc.Default.GetInstance<AppViewModel>(); }
        }

        public HomeViewModel HomeViewModel
        {
            get { return SimpleIoc.Default.GetInstance<HomeViewModel>(); }
        }

        public PanelViewModel PanelViewModel
        {
            get { return SimpleIoc.Default.GetInstance<PanelViewModel>(); }
        }

        public CategoryViewModel CategoryViewModel
        {
            get { return SimpleIoc.Default.GetInstance<CategoryViewModel>(); }
        }

        public DataService DataService
        {
            get { return SimpleIoc.Default.GetInstance<DataService>(); }
        }
    }

}
