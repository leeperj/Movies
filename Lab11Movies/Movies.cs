using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Movies
{
    class Movies
    {
        #region Fields aka Data Members
        private string title;
        private string category;
        #endregion

        #region Properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
            public string Category
        {
            get
            {
                return category;    
            }
            set
            {
                category = value;
            }
        }
        #endregion

        #region Constructors
        public Movies()
        {

        }

        public Movies(string _title, string _category)
        {
            title = _title;
            category = _category;
        }
        #endregion

        #region Methods
        

        #endregion
    }
}
