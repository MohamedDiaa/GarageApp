using System;
using GarageApp.Vehicle;
using GarageApp.Sevices;
using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GarageApp
{
	public class Garage<T> : IEnumerable<T> where T: IVehicle
	{
		private uint capacity;
		private T?[] vehicles;


        public Garage(uint capacity)
        {
            this.capacity = capacity;
            this.vehicles = new T[0];
        }

        public Garage(uint capacity, T[] initalVehicles)
		{
			this.capacity = capacity;
			this.vehicles = initalVehicles;
        }

        public T[] ParkedList() {

            return vehicles.Where(c => c != null).ToArray();
        }


		public void add(T item) {

            if (vehicles.Count() >= capacity) {
                throw new ArgumentException("Garage is full");
            }

            this.vehicles = (T?[])vehicles.Append(item).ToArray();
    	}

        public void removeItem(string registerationNumber)
        {
            var vehicle = find(registerationNumber);

            var index = Array.IndexOf(vehicles, vehicle);
          //  vehicles[index] = null;
        }

        public T find(string registerationNumber) {

          return vehicles.Where(p => p.Registreringsnumber == registerationNumber).First();

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

