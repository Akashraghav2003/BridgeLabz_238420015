using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class HotelBooking
    {
        public string guestName { get; set; }
        public string roomType { get; set; }
        public int nights { get; set; }

        public HotelBooking()
        {
            guestName = "akash singh ";
            roomType = "special";
            nights = 2;
        }
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }
        public HotelBooking(HotelBooking other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        public void Dispaly()
        {
            Console.WriteLine($"Guest Name: {guestName}, RoomType: {roomType}, nights: {nights}");
        }

        public static void Main(string[] args)
        {
            HotelBooking hotelBooking = new HotelBooking();
            hotelBooking.Dispaly();

            Console.WriteLine("Write the guest name: ");
            string guestName = Console.ReadLine();
            Console.WriteLine("Write the room type: ");
            string roomType = Console.ReadLine();
            Console.WriteLine("Write the number of night stay :");
            int nights = Convert.ToInt32(Console.ReadLine());

            HotelBooking hotelBooking1 = new HotelBooking(guestName, roomType, nights);
            hotelBooking1.Dispaly();

            HotelBooking hotelBooking3 = new HotelBooking(hotelBooking1);
            hotelBooking3.Dispaly();
        }
    }
}
