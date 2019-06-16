using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingApp.src.DTO;
using ParkingApp.src.Model;
using ParkingApp.src.Repositories;

namespace ParkingApp.src.Controller
{
    class SpotStatusController
    {
        public List<SpotStatusDTO> GetSpotsStatus(int vehicleType)
        {
            List<SpotStatusDTO> spotStatusDTOComplete = new List<SpotStatusDTO>();
            SpotRepository spotRepository = new SpotRepository();
            List<Slot> spots = spotRepository.GetSpots();

            foreach(Slot spot in spots)
            {
                if (spot.Type.Id == vehicleType || vehicleType == 0)
                {
                    SpotStatusDTO particularDTO = new SpotStatusDTO();
                    SlotHistory actualStatus = spotRepository.GetActualSpotHistory(spot.Id);
                    particularDTO.Slot = spot.Id;
                    particularDTO.SlotType = spot.Type.Description;
                    particularDTO.Status = actualStatus.Status.Name;
                    if (actualStatus.Vehicle != null)
                        particularDTO.LicensePlateNumber = actualStatus.Vehicle.LicensePlateNumber;
                    else
                        particularDTO.LicensePlateNumber = "";
                    spotStatusDTOComplete.Add(particularDTO);
                }
            }
            return spotStatusDTOComplete;
        }
    }
}
