using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using NaC.Model;
using NaC.ViewModel.Views;

namespace NaC.ViewModel
{
    public sealed class GameViewModel: BaseViewModel
    {
        private readonly IGameView gameView;

        public Map Map { get; }
        public Player FirstPlayer { get; }
        public Player SecondPlayer { get; }

        public Int32 Turn { get => 9 - Map.EmptyCount; }
        public Boolean IsFirstPlayersTurn { get => Turn % 2 == 0;}

        public GameViewModel(GameType gameType, IGameView gameView)
        {
            this.Map = new Map();

            this.FirstPlayer = new UserPlayer(Cell.Cross, Map, new UserPlayerViewModel() );
            if (gameType == GameType.MultiPlayer) 
                this.SecondPlayer = new UserPlayer(Cell.Noughts, Map, new UserPlayerViewModel());
            else if (gameType == GameType.Easy)
                this.SecondPlayer = new RandomPlayer(Cell.Noughts, Map);
            else throw new ArgumentOutOfRangeException(nameof(gameType) ,"не может быть");
            
            this.gameView = gameView;
            if(gameType == GameType.MultiPlayer)
                this.gameView.FieldButtonClicked += GameView_FieldButtonClicked_Multy;
            else this.gameView.FieldButtonClicked += GameView_FieldButtonClicked_Single;
            this.gameView.Show();
        }

        private void GameView_FieldButtonClicked_Multy(Object sender, FieldButtonEventArgs e)
        {
            throw new NullReferenceException();
        }

        private void GameView_FieldButtonClicked_Single(Object sender, FieldButtonEventArgs e)
        {
            UserPlayerViewModel upvm = ((FirstPlayer as UserPlayer)?.UserInput as UserPlayerViewModel);

            upvm.InputHandler(sender, e);
            FirstPlayer.Do();
            SecondPlayer.Do();

            Cell winner = Map.FindWinner();
            if (winner != Cell.Empty)
                gameView.GameEnd(winner.ConvertToVMCell());

            MapDraw();
        }

        private void MapDraw()
        {
            for (int row = 0; row <= 2; row++)
                for (int column = 0; column <= 2; column++)
                    gameView.Set(row, column, Map.Get(row, column).ConvertToVMCell());
        }
    }
}
