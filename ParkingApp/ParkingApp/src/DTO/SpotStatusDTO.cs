using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.DTO
{
    class SpotStatusDTO
    {
        private int slot;        
        private string slotType;
        private string status;
        private string licensePlateNumber;
        private string vehicleType;

        public int Slot { get => slot; set => slot = value; }
        public string SlotType { get => slotType; set => slotType = value; }
        public string LicensePlateNumber { get => licensePlateNumber; set => licensePlateNumber = value; }
        public string Status { get => status; set => status = value; }
        public string VehicleType { get => VehicleType; set => VehicleType = value; }
    }
}
