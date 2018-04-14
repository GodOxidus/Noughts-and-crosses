using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaC.ViewModel
{
    public abstract class BaseViewModel:INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RealiseProperty(String propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
