using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.Hotel.Data.Helpers
{
    public class FoodOrderHelper
    {
        public void Insert(string FoodName, string Date, int Price, int Quantity,int CustomerId, int RoomId )
        {
            FoodOrder foodOrder = new FoodOrder();
            foodOrder.FoodName = FoodName;
            foodOrder.Date = Date;
            foodOrder.Price = Price;
            foodOrder.Quantity = Quantity;
            foodOrder.CustomerId = CustomerId;
            foodOrder.RoomNoId = RoomId;

            var db = new HOTELEntities1();
            db.FoodOrders.Add(foodOrder);
            db.SaveChanges();
            db.Dispose();

        }
    }
}
