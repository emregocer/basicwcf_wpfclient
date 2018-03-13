using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Client.Models;

namespace WcfTest3.Client.Messages
{
    public class CategoryData
    {
        #region Declarations

        public CategoryModel Category { get; set; }

        #endregion

        #region Constructor

        public CategoryData(CategoryModel category)
        {
            Category = category;
        }

        #endregion
    }

}
