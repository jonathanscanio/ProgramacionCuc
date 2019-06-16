using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingApp.src.Model;
using ParkingApp.src.Repositories;

namespace ParkingApp.src.Availability
{
    class AnyFitStrategy : AvailabilityStrategy
    {
        public List<Slot> GetAvailability(int vehicleType)
        {
            SpotRepository spotRepository = new SpotRepository();
            List<Slot> availabilities= spotRepository.GetSpots(1);
            if (vehicleType != 0)
            {
                List<Slot> fitSpots = new List<Slot>();
                foreach (Slot slot in availabilities)
                {

                    if (slot.Type.Id >= vehicleType)
                        fitSpots.Add(slot);
                }
                availabilities = fitSpots;
            }
            return availabilities;
        }


    }
}
