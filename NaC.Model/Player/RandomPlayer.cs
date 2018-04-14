using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaC.Model
{
    public sealed class RandomPlayer: Player
    {
        private Random random;

        public RandomPlayer(Cell cell, Map map) : base(cell, map)
        {
            random = new Random();
        }

        public override void Do()
        {
            //Int32 rndNum = random.Next(0, Map.EmptyCount);
            //Int32 result = 0;
            //for (int i = 0; i < rndNum; i++)
            //{
            //    if(Map.Get(i) != Cell.Empty) result++;
            //    result++;
            //}
            //Map.Set(result, base.BaseCell);

            for (int i = 0; i < 9; i++)
            {
                if (Map.Get(i) == Cell.Empty)
                {
                    Map.Set(i, base.BaseCell);
                    return;
                }
            }
        }
    }
}
