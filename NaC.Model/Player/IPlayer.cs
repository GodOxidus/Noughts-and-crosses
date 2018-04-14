using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaC.Model
{
    public interface IUserPlayer
    {
        void GetUserInput(out Int32 row, out Int32 column);
    }
}
