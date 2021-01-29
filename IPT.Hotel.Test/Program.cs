using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPT.Hotel.Data.Helpers;

namespace IPT.Hotel.Test
{
     public class Program
    {
        public static void Main()
        {
            CustomerHelper customerHelper = new CustomerHelper();
            // customerHelper.Insert("Sarmed", "Rizvi", "03088789644", "Gulberg", "Sarmedrizvi@gmail.com");
            //customerHelper.Insert("Zammar", "Ahmed", "03088789644", "Fb-Area", "Zammar Ahmed@gmail.com");
            //customerHelper.Insert("Salman", "Siddiqui", "03088908644", "Fb-Area", "Salmansiddiqui@gmail.com");
            //// customerHelper.Insert("Khuzaima", "sultan", "03083434564", "Gulshan", "Khuzaimah80@gmail.com");
            // customerHelper.Insert("Sameer", "Shah", "030435544", "Sadar", "Sameer90@gmail.com");
            // customerHelper.Insert("Maaz", "Tauseef", "030887789644", "Korangi", "Maaz33@gmail.com");

            RoomHelper roomHelper = new RoomHelper();
            //roomHelper.Insert(21, "double", 12000, "090098601", 2, 2);
            //roomHelper.Insert(22, "double", 12000, "090018601", 2, 2);
            //roomHelper.Insert(11, "Triple", 18000, "090092601", 3, 1);
            //roomHelper.Insert(23, "double", 12000, "090098301", 2, 2);
            //roomHelper.Insert(12, "Triple", 18000, "090098661", 3, 1);
            //roomHelper.Insert(33, "single", 12000, "090098609", 1, 4);

            BookingHelper bookingHelper = new BookingHelper();
            //bookingHelper.Insert("23dec,2020", "25dec,2020", 5, 22);
            // bookingHelper.Insert("21dec,2020", "31dec,2020", 3, 12);
            // bookingHelper.Insert("20dec,2020", "25dec,2020", 4, 23);
            //bookingHelper.Insert("22dec,2020", "31dec,2020", 6, 21);
            // bookingHelper.Insert("23dec,2020", "25dec,2020", 5, 11);

            FoodOrderHelper foodOrderHelper = new FoodOrderHelper();
            foodOrderHelper.Insert("Pasta", "21dec,2020", 1200, 2, 3, 12);
            foodOrderHelper.Insert("Rice", "24dec,2020", 1000, 5, 6, 21);

        }
    }

    
}

