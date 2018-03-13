using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Client.Models;
using WcfTest3.Client.CategoryService;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using WcfTest3.Client.Messages;
using WcfTest3.Client.Helpers;

namespace WcfTest3.Client
{
    public class PanelViewModel : ObservableObject, IPageViewModel
    {
        public string Name { get { return "PanelView"; } set { } }
        private ICommand _getPostsCommand;
        private ICollection<CategoryModel> _categories { get; set; }
        CategoryServiceClient _categoryService = SimpleIoc.Default.GetInstance<DataService>().CategoryService;

        public PanelViewModel()
        {        
        }

        public ICollection<CategoryModel> Categories
        {
            get
            {
                if (_categories == null)
                    _categories = GetCategories();

                return _categories;
            }
        }

        public ICommand GetPostsCommand
        {
            get
            {
                if (_getPostsCommand == null)
                {
                    _getPostsCommand = new RelayCommand(p => ChangePage((int)p), p => (int)p != 0);
                }
                return _getPostsCommand;
            }
        }

        private void ChangePage(int Id)
        {
            Messenger.Default.Send(new CategoryData(_categories.SingleOrDefault(c => c.Id == Id)));
        }

        public ICollection<CategoryModel> GetCategories()
        {
            var queryResult = _categoryService.GetAll();
            List<CategoryModel> categories = new List<CategoryModel>();

            foreach (var category in queryResult)
            {
                categories.Add(new CategoryModel { Id = category.Id, Name = category.Name, Description = category.Description });
            }
            return categories;
        }
    }
}
