using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaC.ViewModel.EventArgs;

namespace NaC.ViewModel.Views
{
    public interface IStartView : IView
    {
        event EventHandler<NewGameEventArgs> StartGameClicked;
    }
}
