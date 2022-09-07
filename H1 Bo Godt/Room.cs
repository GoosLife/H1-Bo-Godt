using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal abstract class Room
    {
        protected int size;
        protected List<Window> windows;
        protected List<Door> doors;

        protected Room(int size, List<Window> windows, List<Door> doors)
        {
            this.size = size;
            this.windows = windows;
            this.doors = doors;
        }

        /// <summary>
        /// The size of the room in m2.
        /// </summary>
        public int Size { get { return size; } }

        /// <summary>
        /// A read-only collection of the doors in the room.
        /// </summary>
        public ReadOnlyCollection<Door> Doors { get { return doors.AsReadOnly(); } }

        /// <summary>
        /// A read-only collection of the windows in the room.
        /// </summary>
        public ReadOnlyCollection<Window> Windows { get { return windows.AsReadOnly(); } }
    }
}
