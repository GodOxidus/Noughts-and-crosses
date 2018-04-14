using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaC.ViewModel.Views;

namespace NaC.ViewModel.EventArgs
{
    public class NewGameEventArgs: System.EventArgs
    {
        public GameType GameType;
        public IGameView GameView;

        public NewGameEventArgs(GameType gameType, IGameView gameView)
        {
            GameType = gameType;
            GameView = gameView;
        }
    }
}
