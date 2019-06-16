using System.Collections.Generic;
using ParkingApp.src.Model;
using ParkingApp.src.View;
using ParkingApp.src.Availability;
using ParkingApp.src.Repositories;
using System;

namespace ParkingApp.src.Controller
{
    class AvailabilityController
    {

        private AvailabilityScreen view;

        public AvailabilityController()
        {
        }

        public AvailabilityController(AvailabilityScreen view)
        {
            this.view = view;
        }
        
        public List<AvailabilityDTO> GetAvailability(int vehicleType,string criteria)
        {
            List<AvailabilityDTO> availabilityDTO = new List<AvailabilityDTO>();
            List<Slot> availability = new List<Slot>();
            AvailabilityStrategy strategy = StrategyFactory.Instance.GetStrategy(criteria);
            availability = strategy.GetAvailability(vehicleType);
            BookingRepository bookingRepository = new BookingRepository();
            foreach(Slot spot in availability)
            {
                AvailabilityDTO availableSpot = new AvailabilityDTO();
                availableSpot.Slot = spot.Id;
                availableSpot.SlotType = spot.Type.Description;
                List<Booking> pendingBookings=bookingRepository.GetBookings(spot.Id, BookingStatus.Created.ToString());
                if (pendingBookings.Count == 0)
                    availableSpot.EndTime = DateTime.UtcNow.AddDays(360);
                else
                    availableSpot.EndTime = pendingBookings[0].StartTime; 
                availabilityDTO.Add(availableSpot);
            }
            return availabilityDTO;
        }
	}
}
