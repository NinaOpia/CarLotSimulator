using System;
using System.Collections.Generic;
using System.Linq;


namespace CarLotSimulator
{
    class Program
    {
        public static Car corvette;
        public static Car ford;
        public static Car jeep;

        public static string Year { get; set; }
        public static string Make { get; set; }
        public static string Model { get; set; }
        public static string EngineNoise { get; set; }
        public static string HonkNoise { get; set; }
        public static bool IsDriveable { get; set; }

        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property - DONE


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var jeremysCarLot = new CarLot();
            Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}\n");

            //Dot notation syntax
            var corvette = new Car();
            corvette.Year = "2023";
            corvette.Make = "Chevrolet";
            corvette.Model = "Corvette";
            corvette.EngineNoise = "vroom!!";
            corvette.HonkNoise = "Honk!!";
            corvette.IsDriveable = true;

            jeremysCarLot.ParkingLot.Add(corvette);

            //CarLot.numberOfCars++;
            //Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}\n");

            //Object initializer syntax
            var ford = new Car();
            {
                Year = "2004";
                Make = "Ford";
                Model = "Focus";    
                EngineNoise = "shake shake live";
                HonkNoise = "tiny beep";
                IsDriveable = false;
            };
           

            jeremysCarLot.ParkingLot.Add(ford);

            //CarLot.numberOfCars++;
            //Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}\n");

            //Custom constructor
            var jeep = new Car("2017", "Jeep", "Wrangler Unlimited", "Vroom!!", "Honk!!", true);

            jeremysCarLot.ParkingLot.Add(jeep);

            //CarLot.numberOfCars++;
            //Console.WriteLine($"Number of cars in the lot: {CarLot.numberOfCars}\n");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in jeremysCarLot.ParkingLot)
            {
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");

                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
                Console.WriteLine();
            }
        }
    }
}
