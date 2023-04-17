using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot()
		{
			 
		}

		public static int numberOfCars; //Field is a variable used inside of a class

		public List<Car> ParkingLot { get; set; } = new List<Car>();
	}
}

