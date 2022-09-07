using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Bo_Godt
{
    internal class OneBedroomApartment : Apartment
    {
        public OneBedroomApartment(Floor floor, Door frontDoor, Door backDoor) : base(floor, frontDoor, backDoor)
        {
            // Create windows and doors for each room, as per the minimum requirement. These can be changed later.
            List<Window> livingRoomWindow = new List<Window>() { new SingleWindow(false, true) };
            List<Door> livingRoomDoor = new List<Door>() { new Door() };

            List<Window> bathroomWindow = new List<Window>() { new SingleWindow(false, true) };
            List<Door> bathroomDoor = new List<Door>() { new Door() };

            // Initialize rooms with minimum requirements.
            rooms = new Room[3]
            {
                new Livingroom(15, livingRoomWindow, livingRoomDoor, new DoubleWindow(false,true)),
                new Kitchen(),
                new Bathroom(10, bathroomWindow, bathroomDoor),
            };
        }
    }
}
