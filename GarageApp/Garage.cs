using System;
using GarageApp.Vehicle;
using GarageApp.Sevices;
using System.Collections;
using System.Collections.Generic;

namespace GarageApp
{
	public class Garage<T> : IEnumerable<T> where T: IVehicle
	{
		uint capacity;
		private T[] vehicles;


        public Garage(uint capacity)
        {
            this.capacity = capacity;
            this.vehicles = new T[capacity + 1];
        }

        public Garage(uint capacity, T[] initalVehicles)
		{
			this.capacity = capacity;
			this.vehicles = new T[capacity + 1];
        }

        public T[] ParkedList() {

			return vehicles.Where(c => c != null).ToArray();
        }


		public Boolean add(T item) {

            for (int index = 0; index < capacity; index++) {
               var v = vehicles[index];
                if (v == null) {
                    vehicles[index] = item;
                    return true;
                }
            }

            return false;
		}

        public IVehicle removeVehicle()
        {
			throw new NotImplementedException("to be done");
        }

		public IVehicle find(string registerationNumber) {

            throw new NotImplementedException("to be done");

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vehicles)
            {
                yield return (T)item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


    }
}

