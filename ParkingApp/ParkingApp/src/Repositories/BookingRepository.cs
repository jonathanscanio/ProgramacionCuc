using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingApp.src.Model;

namespace ParkingApp.src.Repositories
{
    class BookingRepository:GeneralRepository
    {
        public BookingRepository(): base()
        {

        }

        public List<Booking> GetBookings(int spot,string status)
        {
            List<Booking> bookings = new List<Booking>();
            connection.Open();
            string query = Resources.Booking.GetBookingBySpotAndStatus.Replace("SpotIdNeeded",spot.ToString()).Replace("StatusNeeded",status);
            SQLiteCommand sql_cmd = connection.CreateCommand();
            sql_cmd.CommandText = query;
            SQLiteDataReader reader = sql_cmd.ExecuteReader();
            while (reader.Read())
            {
                Booking booking = new Booking();
                booking.Id = reader.GetInt32(0);
                booking.StartTime = reader.GetDateTime(1);
                booking.EndTime = reader.GetDateTime(2);
                booking.Status = reader.GetString(3);
            }
            connection.Close();
            bookings.OrderBy(x => x.StartTime);
            return bookings;
        }

        public List<Booking> GetBookings(int timeSlot)
        {
            List<Booking> bookings = new List<Booking>();
            return bookings;
        }

        public List<Booking> GetBookings(string status)
        {
            List<Booking> bookings = new List<Booking>();
            return bookings;
        }
    }
}
