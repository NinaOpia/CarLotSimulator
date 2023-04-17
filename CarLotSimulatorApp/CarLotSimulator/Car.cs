using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
		}

        //Custom constructor
        public Car(string year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make; 
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

		public string Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }

        public object ListOfCars { get; set; }

        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"The car engine goes {engineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"The car's horn goes {honkNoise}");
        }
    }
}

