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



        IVehicle c1 = new Car(
            registreringsnumber: "2123123",
            color: ConsoleColor.Black,
            numberOfEngines: 3,
            cylinderVolume: 100,
            fuel: FuelType.Diesel,
            numberOfSeats:4,
            dimension: new Dimension(width: 100, height: 100)
            );

        IVehicle c2 = new Car(
         registreringsnumber: "2123124",
         color: ConsoleColor.Black,
         numberOfEngines: 3,
         cylinderVolume: 100,
         fuel: FuelType.Diesel,
         numberOfSeats: 4,
         dimension: new Dimension(width: 100, height: 100)
         );

        IVehicle c3 = new Car(
         registreringsnumber: "2123125",
         color: ConsoleColor.Black,
         numberOfEngines: 3,
         cylinderVolume: 100,
         fuel: FuelType.Diesel,
         numberOfSeats: 4,
         dimension: new Dimension(width: 100, height: 100)
         );

        IVehicle[] vs = new IVehicle[] { c1, c2, c3 };

        GarageHandler hanedler = new GarageHandler(capacity: 4, initalVehicles: vs);

        
        hanedler.ListAllVehicles();

        IVehicle cx = hanedler.Find(registerationNumber: "2123125");
        Console.WriteLine(cx.GetType());
    }
}

