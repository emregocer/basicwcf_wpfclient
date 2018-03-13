using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfTest3.Client;

namespace WcfTest3.Client.Models
{
    public class PostModel : ObservableObject
    {
        #region Fields
        private int _Id;
        private string _Subject;
        private string _SentBy;
        private DateTime _SentAt;
        #endregion

        #region Properties
        public int Id
        {
            get { return _Id; }
            set
            {
                if (value != _Id)
                {
                    _Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public string Subject
        {
            get { return _Subject; }
            set
            {
                if (value != _Subject)
                {
                    _Subject = value;
                    OnPropertyChanged("Subject");
                }
            }
        }

        public string SentBy
        {
            get { return _SentBy; }
            set
            {
                if (value != _SentBy)
                {
                    _SentBy = value;
                    OnPropertyChanged("SentBy");
                }
            }
        }

        public DateTime SentAt
        {
            get { return _SentAt; }
            set
            {
                if (value != _SentAt)
                {
                    _SentAt = value;
                    OnPropertyChanged("SentAt");
                }
            }
        }
        #endregion
    }
}
