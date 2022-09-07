using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal class Kitchen : Room // All the kitchens are the same, so the IChangeWindow interface isn't included here.
    {
        // The values for the size, window and door (which are the requirements for this room) are hardcoded here,
        // because it is a requirement that all kitchens MUST be identical.
        public Kitchen() : base(15, new(), new()) 
        {
            doors.Add(new Door());
            windows.Add(new SingleWindow(false, true));
        }
    }
}
