using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaC.Model
{
    public abstract class Player
    {
        public Cell BaseCell { get; }
        public Map Map { get; }

        public abstract void Do();

        protected Player(Cell cell, Map map)
        {
            BaseCell = cell;
            Map = map;
        }
    }
}
