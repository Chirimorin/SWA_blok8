using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokubasis
{
    public interface IPropertyChanged : INotifyPropertyChanged
    {
        void NotifyPropertyChanged();
    }
}
