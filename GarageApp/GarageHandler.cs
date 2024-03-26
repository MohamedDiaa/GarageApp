using System;
using GarageApp.Sevices;

namespace GarageApp
{
	public class GarageHandler
	{
		Garage<IVehicle> vechiles;

        public GarageHandler(uint capacity)
		{
            vechiles = new(capacity: capacity);
        }
	}
}

