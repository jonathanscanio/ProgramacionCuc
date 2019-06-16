using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.Model
{
	class Slot
	{
		private int id;
        private VehicleType type;
		public int Id{ get => id; set => id = value; }
        public VehicleType Type { get => type; set => type = value; }

    }
}
