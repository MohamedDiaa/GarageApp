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


        GarageHandler hanedler = new GarageHandler(capacity: 3);

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

        hanedler.addVehicle(c1);
        hanedler.addVehicle(c2);
        hanedler.addVehicle(c3);

        hanedler.listAllVehicles();
    }
}

