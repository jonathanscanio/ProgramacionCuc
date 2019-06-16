using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.Model
{
    class SlotHistory
    {
        private Slot slot;
        private SlotStatus status;
        bool isActual;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private Vehicle vehicle;

        public bool IsActual { get => isActual; set => isActual = value; }
        public DateTime StartDateTime { get => startDateTime; set => startDateTime = value; }
        public DateTime EndDateTime { get => endDateTime; set => endDateTime = value; }
        public Slot Slot { get => slot; set => slot = value; }
        public SlotStatus Status { get => status; set => status = value; }
        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
    }
}
