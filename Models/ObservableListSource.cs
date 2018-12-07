using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppEF.Models  //If using web applications this doesn't have to be done. 
{
    class ObservableListSource<T> : ObservableCollection<T>, IListSource where T: BaseModel
    {
        private IBindingList _bindingList;
        bool IListSource.ContainsListCollection { get { return false; } }
        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
