using System;
using System.Collections.Generic;
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

        public void ListAllVehicles() {

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


        public void ListAllVehiclesTypes() {
            // TO do

           var dic =  garage.ListAllVehiclesTypes();
            foreach((string s, int count) in dic) {
                Console.WriteLine($"type {s} occurs {count}");
            }
        }


        public void AddVehicle(IVehicle v) {

            try
            {
                garage.Add(v);
            }
            catch {
            }
        }

        public void RemoveVehicle(string registerationNumber) {

            garage.RemoveItem(registerationNumber: registerationNumber);
        }

        public IVehicle Find(string registerationNumber) => garage.Find(registerationNumber: registerationNumber);

    }

}

