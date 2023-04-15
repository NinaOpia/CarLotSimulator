using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
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

            var jeremysCarlot = new Carlot();

            //Dot notation syntax
            var corvette = new Car();
            corvette.Year = "2023";
            corvette.Make = "Chevrolet";
            corvette.Model = "Corvette";
            corvette.EngineNoise = "vroom!!";
            corvette.HonkNoise = "Honk!!";
            corvette.IsDriveable = true;

            jeremysCarlot.ParkingLot.Add(corvette);

            //Object initializer syntax
            var ford = new Car()
            {
                Year = "2004",
                Make = "Ford",
                Model = "Focus",
                EngineNoise = "shake shake wake",
                HonkNoise = "tiny beep",
                IsDriveable = false
            };

            jeremysCarlot.ParkingLot.Add(ford);

            //Custom constructor
            var jeep = new Car("2017", "Jeep", "Wrangler Unlimited", "Vroom!!", "Honk!!", true);

            jeremysCarlot.ParkingLot.Add(jeep);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in jeremysCarlot.ParkingLot)
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
