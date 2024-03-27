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


		public void Add(T item) {

            if (vehicles.Count() >= capacity) {
                throw new ArgumentException("Garage is full");
            }

            this.vehicles = (T?[])vehicles.Append(item).ToArray();
    	}

        public void RemoveItem(string registerationNumber)
        {
            var vehicle = Find(registerationNumber);

            var index = Array.IndexOf(vehicles, vehicle);
            //  vehicles[index] = null;
            this.vehicles = vehicles.Where(p => p.Registreringsnumber.ToLower() != registerationNumber.ToLower()).ToArray();
        }

        public T Find(string registerationNumber) {

          return vehicles.Where(p => p.Registreringsnumber.ToLower() == registerationNumber.ToLower()).First();

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in vehicles)
            {
                yield return (T)item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


        public Dictionary<string, int> ListAllVehiclesTypes()
        {
            // TO do

            Dictionary<string, int> dic = new();

            foreach (var item in vehicles)
            {
                var s = item.GetType().ToString();

                try
                {
                    dic[s] = dic[s] + 1;
                }
                catch {

                    dic[s] = 1;
                }
                //if dic[s] != null {
                //}
                //else {
                //    dic[s] = 1;
                //}
            }
            return dic;
        }
    }
}

