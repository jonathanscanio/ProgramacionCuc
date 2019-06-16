using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingApp.src.Model;

namespace ParkingApp.src
{
    class AvailabilityDTO
    {
        private int slot;
        private DateTime endTime;
        string slotType;

        public int Slot { get => slot; set => slot = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public string SlotType { get => slotType; set => slotType = value; }

    }
}
