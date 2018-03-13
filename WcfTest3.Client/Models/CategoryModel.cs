using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfTest3.Client.Models
{
    public class CategoryModel : ObservableObject
    {
        #region Fields
        private int _Id;
        private string _Name;
        private string _Description;
        #endregion

        #region Properties
        public int Id
        {
            get { return _Id; }
            set
            {
                if(value != _Id)
                {
                    _Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                if(value != _Name)
                {
                    _Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                if (value != _Description)
                {
                    _Description = value;
                    OnPropertyChanged("Description");
                }
            }
        }
        #endregion

    }
}
