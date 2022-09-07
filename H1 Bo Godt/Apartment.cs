using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal abstract class Apartment
    {
        protected Room[] rooms;
        protected Floor floor;
        protected Door frontDoor;
        protected Door backDoor;

        protected Apartment(Floor floor, Door frontDoor, Door backDoor)
        {
            this.floor = floor;
            this.frontDoor = frontDoor;
            this.backDoor = backDoor;
        }

        public Room[] Rooms { get { return rooms; } }
        public Floor Floor { get { return floor; } set { floor = value; } }
        public Door FrontDoor { get { return frontDoor; } set { frontDoor = value; } }
        public Door BackDoor { get { return backDoor; } set { backDoor = value; } }

        public string PrintRooms()
        {
            string result = "";

            foreach (Room r in rooms)
            {
                result += r;
                result += '\n';
            }

            return result;
        }
    }
}
