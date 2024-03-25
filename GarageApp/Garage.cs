using System;
using GarageApp.Vehicle;
using GarageApp.Sevices;

namespace GarageApp
{
	public class Garage<T> where T: IVehicle
	{
		uint capacity;
		private IVehicle[] vehicles;
			 
		public Garage(uint capacity, IVehicle[] initalVehicles)
		{
			this.capacity = capacity;
			vehicles = new Vehicle.Vehicle[capacity + 1];

            if(initalVehicles.Count() <= capacity) { 


            }
        }

		public IVehicle[] ParkedList() {

			return vehicles.Where(c => c != null).ToArray();

        }


		public void addVehicle(IVehicle vehicle) {

		}

        public IVehicle removeVehicle()
        {
			throw new NotImplementedException("to be done");
        }

		public IVehicle find(string registerationNumber) {

            throw new NotImplementedException("to be done");

        }
    }
}

