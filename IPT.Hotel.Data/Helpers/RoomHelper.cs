using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.Hotel.Data.Helpers
{
    public class RoomHelper
    {
        public  void Insert(int RoomNo,string Type,int Price, string Telephone, int NoOfBeds, int RoomFloor)
        {
            Room room = new Room();
            room.RoomNo = RoomNo;
            room.Type = Type;
            room.Price = Price;
            room.Telephone = Telephone;
            room.NoOfBeds = NoOfBeds;
            room.RoomFloor = RoomFloor;

            var db = new HOTELEntities1();
            db.Rooms.Add(room);
            db.SaveChanges();
            db.Dispose();
           
        }
    }
}
