using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal class Bedroom : Room, IChangeWindows
    {
        public Bedroom(int size, List<Window> windows, List<Door> doors) : base(size, windows, doors) {}

        /// <summary>
        /// Replace a window in this room with a different window.
        /// </summary>
        /// <param name="index">The index of the window in the list of windows.</param>
        /// <param name="newWindow">The window to be inserted into the list.</param>
        public void ChangeWindow(int index, Window newWindow)
        {
            windows[index] = newWindow;
        }
    }
}
