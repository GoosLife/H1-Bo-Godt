using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal class Bathroom : Room, IChangeWindows
    {
        // This rooms static window
        private readonly Window staticWindow;

        public Bathroom(int size, List<Window> windows, List<Door> doors) : base(size, windows, doors)
        {
            staticWindow = new SingleWindow(true, false); // Bathrooms have at least 1 window that is matted and can't be opened.
        }

        public Window StaticWindow { get { return staticWindow; } }

        public void ChangeWindow(int index, Window newWindow)
        {
            windows[index] = newWindow;
        }
    }
}
