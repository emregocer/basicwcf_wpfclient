using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WcfTest3.Client
{
    public class HomeViewModel : ObservableObject, IPageViewModel
    {
        public string Name { get { return "Home"; } set { } }
    }
}
