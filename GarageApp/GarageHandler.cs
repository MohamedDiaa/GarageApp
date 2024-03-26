using System;
using GarageApp.Sevices;

namespace GarageApp
{
	public class GarageHandler
	{
		private Garage<IVehicle> garage;

        public GarageHandler(uint capacity)
		{
            garage = new(capacity: capacity);
        }

        public GarageHandler(uint capacity, IVehicle[] initalVehicles)
        {
            garage = new(capacity: capacity, initalVehicles: initalVehicles);
        }

        public void listAllVehicles() {

            Console.WriteLine("list all vehicles");

            foreach (IVehicle v in garage) {

                try
                {
                    Console.WriteLine(v.Registreringsnumber);
                }
                catch {
                }
            }
        }


        public void listAllVehiclesTypes() {
            // TO do
        }


        public void addVehicle(IVehicle v) {

            try
            {
                garage.add(v);
            }
            catch {
            }
        }

        public void removeVehicle(string registerationNumber) {

            garage.removeItem(registerationNumber: registerationNumber);
        }
    }

}

