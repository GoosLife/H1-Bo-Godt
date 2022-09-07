using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal class ThreeBedroomApartment : TwoBedroomApartment
    {
        public ThreeBedroomApartment(Floor floor, Door frontDoor, Door backDoor) : base(floor, frontDoor, backDoor)
        {
            // Create an array of rooms that is 1 larger than that of the apartments one size below
            Room[] roomsTemp = new Room[rooms.Length + 1];

            // Add the rooms from the smaller sized apartment to this apartment type
            for (int i = 0; i < rooms.Length; i++)
            {
                roomsTemp[i] = rooms[i];
            }

            // Create the extra bedroom and add it to the array of rooms
            List<Window> bedroomWindow = new List<Window>() { new SingleWindow(false, true) };
            List<Door> bedroomDoor = new List<Door>() { new Door() };

            roomsTemp[roomsTemp.Length - 1] = new Bedroom(15, bedroomWindow, bedroomDoor);

            // The apartment is now complete with the necessary rooms
            rooms = roomsTemp;
        }
    }
}
