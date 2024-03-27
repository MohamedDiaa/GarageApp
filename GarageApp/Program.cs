namespace GarageApp;
using GarageApp.Util;
using System.Drawing;
using GarageApp.Vehicle;
using GarageApp.Sevices;
using GarageApp.Util;

class Program
{
   static void Main(string[] args)
    {
        GarageHandler handlar;

        Console.WriteLine("Welcome Garage app.\nplease enter capacity");
        string s = Console.ReadLine();
        uint.TryParse(s, out uint capcity);
        handlar = new GarageHandler(capacity: capcity);

        do
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Add a Vehicle"
                    + "\n2. Remove a Vehicle"
                    + "\n3. List all Vehicle"
                    + "\n4. List types of Vehicles"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        IVehicle v = generateVehicle();
                       handlar.AddVehicle(v);
                        break;
                    case '2':
                        Console.WriteLine("Enter registeration number of vehicle to be removed");
                        string registerNumber = Console.ReadLine();
                        handlar.RemoveVehicle(registerationNumber: registerNumber);
                        break;
                    case '3':
                        handlar.ListAllVehicles();
                        break;
                    case '4':
                        handlar.ListAllVehiclesTypes();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }

        }
        while (true);

    }

   static void Testing()
    {

        Console.WriteLine("Hello, World!");



        IVehicle c1 = new Car(
            registreringsnumber: "2123123",
            color: ConsoleColor.Black,
            numberOfEngines: 3,
            cylinderVolume: 100,
            fuel: FuelType.Diesel,
            numberOfSeats: 4,
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


        IVehicle c4 = new Boat(
         registreringsnumber: "Boat2123127",
         color: ConsoleColor.Black,
         numberOfEngines: 3,
         cylinderVolume: 100,
         fuel: FuelType.Diesel,
         numberOfSeats: 4,
         dimension: new Dimension(width: 100, height: 100)
         );


        IVehicle c5 = new Bus(
     registreringsnumber: "Buss2123125",
     color: ConsoleColor.Black,
     numberOfEngines: 3,
     cylinderVolume: 100,
     fuel: FuelType.Diesel,
     numberOfSeats: 4,
     dimension: new Dimension(width: 100, height: 100)
     );


        IVehicle[] vs = new IVehicle[] { c1, c2, c3, c4, c5 };

        GarageHandler hanedler = new GarageHandler(capacity: 4, initalVehicles: vs);


        hanedler.ListAllVehicles();

        IVehicle cx = hanedler.Find(registerationNumber: "2123125");
        Console.WriteLine(cx.GetType());

        hanedler.RemoveVehicle(registerationNumber: "2123123");
        hanedler.ListAllVehicles();

        hanedler.ListAllVehiclesTypes();
    }


    static IVehicle generateVehicle() {

        Random rnd = new Random();
        int num = rnd.Next() ;
        int index = num % 5;
        Console.WriteLine(num);

        switch (index) {

            case 1:
                return new Airplane(registreringsnumber: $"{num}",
                    color: ConsoleColor.Green,
                    numberOfEngines: num % 5,
                    cylinderVolume: num ,
                    fuel: FuelType.Diesel,
                    numberOfSeats: 19,
                    dimension: new Dimension(width: 10, height: 10));

            case 2:
                return new Boat(registreringsnumber: $"{num}",
                    color: ConsoleColor.Green,
                    numberOfEngines: num % 5,
                    cylinderVolume: num,
                    fuel: FuelType.Diesel,
                    numberOfSeats: 19,
                    dimension: new Dimension(width: 10, height: 10));

            case 3:
                return new Bus(registreringsnumber: $"{num}",
                    color: ConsoleColor.Green,
                    numberOfEngines: num % 5,
                    cylinderVolume: num,
                    fuel: FuelType.Diesel,
                    numberOfSeats: 19,
                    dimension: new Dimension(width: 10, height: 10));

            case 4:
                return new Car(registreringsnumber: $"{num}",
                    color: ConsoleColor.Green,
                    numberOfEngines: num % 5,
                    cylinderVolume: num,
                    fuel: FuelType.Diesel,
                    numberOfSeats: 19,
                    dimension: new Dimension(width: 10, height: 10));

            default:
                return new Motorcycle(registreringsnumber: $"{num}",
                    color: ConsoleColor.Green,
                    numberOfEngines: num % 5,
                    cylinderVolume: num,
                    fuel: FuelType.Diesel,
                    numberOfSeats: 19,
                    dimension: new Dimension(width: 10, height: 10));
        }
    }
}

