using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaC.Model
{
    public class UserPlayer: Player
    {
        public IUserPlayer UserInput { get; }
        
        public UserPlayer(Cell cell, Map map, IUserPlayer player) : base(cell, map)
        {
            this.UserInput = player;
        }

        public override void Do()
        {
            UserInput.GetUserInput(out var row, out var column);

            Map.Set(row, column, base.BaseCell);
        }
    }
}
