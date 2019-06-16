using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.src.Model
{
	class SlotStatus
	{
		private int id;
		private string name;
		private string description;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Description { get => description; set => description = value; }
	}
}
