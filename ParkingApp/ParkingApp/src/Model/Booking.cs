using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.Model
{
	class Booking
	{
		private int id;
		private DateTime startTime;
		private DateTime endTime;
        private Slot slot;
        private string status;

        public int Id { get => id; set => id = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public Slot Slot { get => slot; set => slot = value; }
        public string Status { get => status; set => status = value; }





    }
}
