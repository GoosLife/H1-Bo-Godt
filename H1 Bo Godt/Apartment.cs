using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal abstract class Apartment
    {
        private Room[] rooms;
        private Floor floor;
        private Door frontDoor;
        private Door backDoor;

        protected Apartment(Floor floor, Door frontDoor, Door backDoor)
        {
            this.floor = floor;
            this.frontDoor = frontDoor;
            this.backDoor = backDoor;
        }

        public Room[] Rooms { get { return rooms; } }
    }
}
