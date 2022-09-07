using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal interface IChangeWindows
    {
        /// <summary>
        /// Replaces a window on a specific index in a collection with a new window.
        /// </summary>
        void ChangeWindow(int index, Window newWindow);
    }
}
