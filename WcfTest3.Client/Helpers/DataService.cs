using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Client.CategoryService;
using WcfTest3.Client.PostService;

namespace WcfTest3.Client.Helpers
{
    // bu sadece kolaylik olsun diye.
    public class DataService
    {
        public DataService()
        {
            Username = "default";
            Password = "123456";
        }

        #region Fields
        private string _Username;
        private string _Password;
        #endregion

        #region Properties
        public string Username
        {
            get { return _Username; }
            set
            {
                if (value != _Username)
                {
                    _Username = value;
                }
            }
        }

        public string Password
        {
            get { return _Password; }
            set
            {
                if (value != _Password)
                {
                    _Password = value;
                }
            }
        }

        public CategoryServiceClient CategoryService
        {
            get
            {
                var categoryService = new CategoryServiceClient();
                categoryService.ClientCredentials.UserName.UserName = Username;
                categoryService.ClientCredentials.UserName.Password = Password;
                return categoryService;
            }
            set { }
        }

        public PostServiceClient PostService
        {
            get
            {
                var postService = new PostServiceClient();
                postService.ClientCredentials.UserName.UserName = Username;
                postService.ClientCredentials.UserName.Password = Password;
                return postService;
            }
            set { }
        }
        #endregion
    }
}