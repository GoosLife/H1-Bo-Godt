using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal class Livingroom : Room, IChangeWindows
    {
        private readonly Window staticWindow;
        public Livingroom(int size, List<Window> windows, List<Door> doors, Window staticWindow) : base(size, windows, doors)
        {
            this.staticWindow = staticWindow;
        }

        public Window StaticWindow { get { return staticWindow; } }

        public void ChangeWindow(int index, Window newWindow)
        {
            windows[index] = newWindow;
        }
    }
}
