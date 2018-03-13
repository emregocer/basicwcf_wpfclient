using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTest3.Client.Login
{
    public class LoginViewModel : ObservableObject, IPageViewModel
    {
        public string Name { get { return "LoginView"; } set { } }
    }
}
