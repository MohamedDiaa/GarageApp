namespace GarageApp;
using GarageApp.Util;
using System.Drawing;
using GarageApp.Vehicle;
using GarageApp.Sevices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Garage<IVehicle> vechiles = new(capacity: 10);
        var c1 = new Car(
            registreringsnumber: "2123123",
            color: ConsoleColor.Black,
            numberOfEngines: 3,
            cylinderVolume: 100,
            fuel: FuelType.Diesel,
            numberOfSeats:4,
            dimension: new Dimension(width: 100, height: 100)
            );

        var c2 = new Car(
         registreringsnumber: "2123124",
         color: ConsoleColor.Black,
         numberOfEngines: 3,
         cylinderVolume: 100,
         fuel: FuelType.Diesel,
         numberOfSeats: 4,
         dimension: new Dimension(width: 100, height: 100)
         );

        var c3 = new Car(
         registreringsnumber: "2123125",
         color: ConsoleColor.Black,
         numberOfEngines: 3,
         cylinderVolume: 100,
         fuel: FuelType.Diesel,
         numberOfSeats: 4,
         dimension: new Dimension(width: 100, height: 100)
         );

        vechiles.add(c1);
        vechiles.add(c2);
        vechiles.add(c3);


        foreach (IVehicle v in vechiles) {
            Console.WriteLine(v.Registreringsnumber);
        }
    }
}

