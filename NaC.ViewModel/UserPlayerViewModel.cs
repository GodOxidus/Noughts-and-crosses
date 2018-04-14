using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NaC.Model;

namespace NaC.ViewModel
{
    internal class UserPlayerViewModel: BaseViewModel, IUserPlayer
    {
        private Int32 lastRow = -1;
        private Int32 lastColumn = -1;
        
        public void InputHandler(Object sender, FieldButtonEventArgs e)
        {
            lastRow = e.Row;
            lastColumn = e.Column;
        }

        public void GetUserInput(out int row, out int column)
        {
            row = lastRow;
            column = lastColumn;

            lastRow = -1;
            lastColumn = -1;
        }
    }
}
