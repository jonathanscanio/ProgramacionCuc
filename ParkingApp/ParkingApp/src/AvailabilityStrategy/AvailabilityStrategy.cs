using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingApp.src.Model;

namespace ParkingApp.src.Availability
{
    interface AvailabilityStrategy
    {

       List<Slot> GetAvailability(int vehicleType);

    }
}
