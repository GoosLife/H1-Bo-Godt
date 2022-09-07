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
        private bool canClose;

        protected Window(bool isMatted, bool canClose)
        {
            this.isMatted = isMatted;
            this.canClose = canClose;
        }

        public bool IsMatted { get { return isMatted; } }
        public bool CanClose { get { return canClose; } }
    }
}
