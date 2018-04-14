using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NaC.Model
{
    public sealed class Map
    {
        private Cell[] map;

        public Map()
        {
            map = new Cell[9];
        }

        public Int32 EmptyCount
        {
            get
            {
                return map.Count(x => x == Cell.Empty);
            }
        }

        public Cell Get(Int32 row, Int32 column)
        {
            return Get(3 * row + column);
        }

        internal Cell Get(Int32 i)
        {
            return map[i];
        }

        internal void Set(Int32 row, Int32 column, Cell c)
        {
            Set((3 * row + column), c);
        }

        internal void Set(Int32 i, Cell c)
        {
            map[i] = c;
        }

        public Cell FindWinner()
        {
            for (int i = 0; i < 3; i++)
                if (Get(i, 0) == Get(i, 1) && Get(i, 0) == Get(i, 2) && Get(i, 0) != Cell.Empty)
                    return Get(i, 0);

            for (int i = 0; i < 3; i++)
                if (Get(0, i) == Get(1, i) && Get(0, i) == Get(2, i) && Get(0, i) != Cell.Empty)
                    return Get(0, i);

            if (Get(0, 0) == Get(1, 1) && Get(0, 0) == Get(2, 2) && Get(0, 0) != Cell.Empty)
                return Get(0, 0);
            if (Get(2, 0) == Get(1, 1) && Get(2, 0) == Get(0, 2) && Get(2, 0) != Cell.Empty)
                return Get(1, 1);

            return Cell.Empty;
        }
    }
}
