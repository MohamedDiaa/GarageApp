using System;
using GarageApp.Vehicle;
using GarageApp.Sevices;

namespace GarageApp
{
	public class Garage<T> where T: IVehicle
	{
		uint capacity;
		private IVehicle[] vehicles;
			 
		public Garage(uint capacity)
		{
			this.capacity = capacity;
			vehicles = new Vehicle.Vehicle[capacity];

        }
	}
}

