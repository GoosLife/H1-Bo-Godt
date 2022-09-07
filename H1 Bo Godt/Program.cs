using System;

namespace H1_Bo_Godt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apartment one = new OneBedroomApartment(new(), new(), new());
            Apartment two = new TwoBedroomApartment(new(), new(), new());
            Apartment three = new ThreeBedroomApartment(new(), new(), new());
            Apartment four = new FourBedroomApartment(new(), new(), new());
            Apartment five = new FiveBedroomApartment(new(), new(), new());

            Apartment[] apps = new Apartment[5] { one, two, three, four, five };

            for (int i = 0; i < apps.Length; i++)
            {
                Console.WriteLine((i + 1) + " bedroom apartment:");
                Console.WriteLine(apps[i].PrintRooms());
            }
        }
    }
}
