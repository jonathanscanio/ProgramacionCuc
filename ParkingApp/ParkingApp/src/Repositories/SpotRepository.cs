using System.Collections.Generic;
using System.Data.SQLite;
using ParkingApp.src.Model;

namespace ParkingApp.src.Repositories
{
    class SpotRepository : GeneralRepository
    {
        public SpotRepository() : base(){
            }

        public List<Slot> GetSpots()
        {
            List<Slot> spots = new List<Slot>();
            connection.Open();
            string query= Resources.SpotResources.GetAllSpots;
            SQLiteCommand sql_cmd = connection.CreateCommand();
            sql_cmd.CommandText = query;
            SQLiteDataReader reader= sql_cmd.ExecuteReader();
            while (reader.Read())
            {
                Slot spot = new Slot();
                VehicleType type = new VehicleType();
                spot.Type = type;
                spot.Id = reader.GetInt32(0);
                spot.Type.Id = reader.GetInt32(2);
                spot.Type.PricePerHour = reader.GetFloat(3);
                spot.Type.Description = reader.GetString(4);
                spots.Add(spot);
            }
            connection.Close();
            return spots;
        }


        public List<Slot> GetSpots(int statusId)
        {
            List<Slot> spots = new List<Slot>();
            connection.Open();
            string query = Resources.SpotResources.GetSpotsByStatus.Replace("statusNeeded",statusId.ToString()); 
            SQLiteCommand sql_cmd = connection.CreateCommand();
            sql_cmd.CommandText = query;
            SQLiteDataReader reader = sql_cmd.ExecuteReader();
            while (reader.Read())
            {
                Slot spot = new Slot();
                VehicleType type = new VehicleType();
                spot.Type = type;
                spot.Id = reader.GetInt32(0);
                spot.Type.Id = reader.GetInt32(2);
                spot.Type.PricePerHour = reader.GetFloat(3);
                spot.Type.Description = reader.GetString(4);
                spots.Add(spot);
            }
            connection.Close();
            return spots;
        }

        public SlotHistory GetActualSpotHistory(int spotId)
        {
            SlotHistory actualSlotHistory = new SlotHistory();
            connection.Open();
            string query = Resources.SpotHistoryResources.GetActualSpotHistory.Replace("SpotNeeded",spotId.ToString());
            SQLiteCommand sql_cmd = connection.CreateCommand();
            sql_cmd.CommandText = query;
            SQLiteDataReader reader = sql_cmd.ExecuteReader();
            while (reader.Read())
            {
                actualSlotHistory.IsActual = true;
                actualSlotHistory.StartDateTime = reader.GetDateTime(2);
                actualSlotHistory.EndDateTime = reader.GetDateTime(3);
                actualSlotHistory.Status = new SlotStatus();
                actualSlotHistory.Status.Id = reader.GetInt32(7);
                actualSlotHistory.Status.Name = reader.GetString(8);
                actualSlotHistory.Vehicle = new Vehicle();
                if (reader.GetInt32(6)!=0)
                {
                    actualSlotHistory.Vehicle.LicensePlateNumber = reader.GetString(11);
                    actualSlotHistory.Vehicle.Year = reader.GetInt32(12);
                    actualSlotHistory.Vehicle.Model = reader.GetString(13);
                    actualSlotHistory.Vehicle.Brand = reader.GetString(14);                    
                }
            }
            connection.Close();
            return actualSlotHistory;

        }


    }
}
