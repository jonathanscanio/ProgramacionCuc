using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.Model
{
	class Vehicle
	{
        private string licensePlateNumber;
		private int year;
		private string model;
		private string brand;
        private VehicleType vehicleType;

        public string LicensePlateNumber { get => licensePlateNumber; set => licensePlateNumber = value; }
        public int Year { get => year; set => year = value; }
		public string Model { get => model; set => model = value; }
		public string Brand { get => brand; set => brand = value; }
        public VehicleType VehicleType { get => vehicleType; set => vehicleType = value; }
    }
}
