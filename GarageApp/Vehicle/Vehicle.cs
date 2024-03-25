using System;
using GarageApp.Sevices;
using GarageApp.Util;

namespace GarageApp.Vehicle
{
    public abstract class Vehicle : IVehicle
    {
        private string registreringsnumber;
        private ConsoleColor color;
        private int numberOfEngines;
        private double cylinderVolume;
        private FuelType fuel;
        private int numberOfSeats;
        private Dimension dimension;


        public Vehicle(string registreringsnumber,
            ConsoleColor color,
            int numberOfEngines,
            double cylinderVolume,
            FuelType fuel,
            int numberOfSeats,
            Dimension dimension
    )
        {
            this.registreringsnumber = registreringsnumber;
            this.color = color;
            this.numberOfEngines = numberOfEngines;
            this.cylinderVolume = cylinderVolume;
            this.fuel = fuel;
            this.numberOfSeats = numberOfSeats;
            this.dimension = dimension;
        }

        public string Registreringsnumber => this.registreringsnumber;

        public int NumberOfEngines => this.numberOfEngines;

        public double CylinderVolume => this.cylinderVolume;

        public int NumberOfSeats => this.numberOfSeats;

        public Dimension Dimension => this.Dimension;

        ConsoleColor IVehicle.color => this.color;

        FuelType IVehicle.Fuel => this.fuel;
    }
}

