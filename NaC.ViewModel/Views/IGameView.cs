using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaC.ViewModel;

namespace NaC.ViewModel.Views
{
    public interface IGameView: IView
    {
        event EventHandler<FieldButtonEventArgs> FieldButtonClicked;
        void Set(Int32 row, Int32 column, VMCell elem);

        void GameEnd(VMCell winner);
    }
}
