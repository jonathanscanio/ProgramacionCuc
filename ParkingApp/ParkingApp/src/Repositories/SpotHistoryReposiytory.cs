using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingApp.src.Model;

namespace ParkingApp.src.Repositories
{
    class SpotHistoryReposiytory : GeneralRepository
    {
        public SpotHistoryReposiytory() : base(){
            }

        List<SlotHistory> GetSpotHistory(int spot)
        {
            List<SlotHistory> spots = new List<SlotHistory>();
            connection.Open();
            string query = "Select * from Spot JOIN VehicleType On Spot.VhicleTypeId = VehicleType.Id";
            SQLiteCommand sql_cmd = connection.CreateCommand();
            sql_cmd.CommandText = query;
            SQLiteDataReader reader = sql_cmd.ExecuteReader();
            while (reader.Read())
            {
                
            }
            connection.Close();
            return spots;
        }
    }
}
