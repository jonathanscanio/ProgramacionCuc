using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.Model
{
    class VehicleType
    {
        private int id;
        private string description;
        private float pricePerHour;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public float PricePerHour { get => pricePerHour; set => pricePerHour = value; }
    }
}
