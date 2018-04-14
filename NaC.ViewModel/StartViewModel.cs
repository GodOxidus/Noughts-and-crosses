using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using NaC.ViewModel.EventArgs;
using NaC.ViewModel.Views;

namespace NaC.ViewModel
{
    public class StartViewModel: BaseViewModel
    {
        private IStartView mainWindow;
        private GameViewModel gameVM;

        public StartViewModel(IStartView mainWindow)
        {
            this.mainWindow = mainWindow;
            this.mainWindow.StartGameClicked += GameInit;
            mainWindow.Show();
        }

        private void GameInit(Object sender, NewGameEventArgs e)
        {
            gameVM = new GameViewModel(e.GameType, e.GameView);
        }
    }
}
