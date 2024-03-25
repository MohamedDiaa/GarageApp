using System;
using GarageApp.Util;
using GarageApp.Vehicle;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GarageApp.Sevices
{
	
    public interface IVehicle
	{

        public string Registreringsnumber { get; }
        public ConsoleColor color { get; }

        public int NumberOfEngines { get; }
        public double CylinderVolume { get; }
        public FuelType Fuel { get; }
        public int NumberOfSeats { get; }
        public Dimension Dimension { get; }

    }
}

