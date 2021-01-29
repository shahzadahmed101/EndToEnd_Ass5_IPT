using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.Hotel.Data.Helpers
{
    public class BookingHelper
    {
        public void Insert( string ArrivalDate, string DepartureDate, int CustomerId ,int RoomId )        {
            Booking booking = new Booking();
            booking.ArrivalDate = ArrivalDate;
            booking.DepartureDate = DepartureDate;
            booking.CustomerId = CustomerId;
            booking.RoomNoId = RoomId;
       
            var db = new HOTELEntities1();
            db.Bookings.Add(booking);
            db.SaveChanges();
            db.Dispose();

        }
    }
}
