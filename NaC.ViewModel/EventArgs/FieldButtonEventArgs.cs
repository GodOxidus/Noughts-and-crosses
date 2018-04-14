using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaC.ViewModel
{
    public class FieldButtonEventArgs: System.EventArgs
    {
        public Int32 Row { get; }
        public Int32 Column { get; }

        public FieldButtonEventArgs(Int32 row, Int32 column)
        {
            Row = row;
            Column = column;
        }
    }
}
