using System;
using GarageApp.Util;

namespace GarageApp.Vehicle
{
    public class Boat : Vehicle
    {
        public Boat(string registreringsnumber,
            ConsoleColor color,
            int numberOfEngines,
            double cylinderVolume,
            FuelType fuel,
            int numberOfSeats,
            Dimension dimension) :
            base(registreringsnumber, color, numberOfEngines, cylinderVolume, fuel, numberOfSeats, dimension)
        {
        }
    }
}

