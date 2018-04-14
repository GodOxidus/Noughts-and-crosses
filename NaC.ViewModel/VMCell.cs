using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaC.Model;

namespace NaC.ViewModel
{
    public enum VMCell
    {
        Empty,
        Cross,
        Nought
    }

    internal static class CellConverter
    {
        public static Cell ConvertToModelCell(this VMCell vmCell)
        {
            return (Cell) ((Int32) vmCell);
        }

        public static VMCell ConvertToVMCell(this Cell mCell)
        {
            return (VMCell)((Int32)mCell);
        }
    }
}
