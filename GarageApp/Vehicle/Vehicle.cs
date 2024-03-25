using System;
using GarageApp.Sevices;

namespace GarageApp.Vehicle
{
	public abstract class Vehicle: IVehicle
    {
        string Registreringsnumber { get; }
        ConsoleColor color { get; }

        int NumberOfEngines { get;  }
        double CylinderVolume { get;  }
        FuelType fuel { get;  }
        int NumberOfSeats { get; }
        int Lenght { get;}



    public Vehicle(string Registreringsnumber,
        ConsoleColor color,
        int NumberOfEngines,
        double CylinderVolume,
        FuelType fuel,
        int NumberOfSeats, int Lenght
)
        {
            this.Registreringsnumber = Registreringsnumber;
            this.color = color;
            this.NumberOfEngines = NumberOfEngines;
            this.CylinderVolume = CylinderVolume;
            this.fuel = fuel;
            this.NumberOfSeats = NumberOfSeats;
            this.Lenght = Lenght;
		}
	}
}

