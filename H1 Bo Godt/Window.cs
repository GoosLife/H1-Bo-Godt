using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal abstract class Window
    {
        private bool isMatted;
        private bool canOpen;

        protected Window(bool isMatted, bool canOpen)
        {
            this.isMatted = isMatted;
            this.canOpen = canOpen;
        }

        public bool IsMatted { get { return isMatted; } }
        public bool CanOpen { get { return canOpen; } }
    }
}
