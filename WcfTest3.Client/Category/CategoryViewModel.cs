using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WcfTest3.Client.Messages;
using WcfTest3.Client.Models;
using WcfTest3.Client.PostService;
using WcfTest3.Client.CategoryService;
using WcfTest3.Client.Helpers;
using System.ServiceModel;

namespace WcfTest3.Client
{
    public class CategoryViewModel : ObservableObject, IPageViewModel
    {
        public string Name { get { return "CategoryView"; } set { } }
        private int CategoryId { get; set; }
        CategoryServiceClient _categoryService = SimpleIoc.Default.GetInstance<DataService>().CategoryService;

        public ICollection<PostModel> Posts { get; set; }

        public CategoryViewModel()
        {
            Messenger.Default.Register<CategoryData>(this, CategorySelected);
        }

        void CategorySelected(CategoryData c)
        {
            CategoryId = c.Category.Id;
            var app = SimpleIoc.Default.GetInstance<AppViewModel>();
            Posts = GetPosts(c.Category.Id);
            app.CurrentPageViewModel = SimpleIoc.Default.GetInstance<CategoryViewModel>();
        }

        public ICollection<PostModel> GetPosts(int categoryId)
        {
            var queryResult = _categoryService.GetCategoryPosts(categoryId.ToString());

            List<PostModel> posts = new List<PostModel>();

            foreach (var post in queryResult)
            {
                posts.Add(new PostModel { Id = post.Id, Subject = post.Subject, SentAt = post.SentAt, SentBy = post.SentBy});
            }

            return posts;
        }

        //post ekleme vs...
    }
}
