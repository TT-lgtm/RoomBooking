using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using RoomBooking.Logic;

namespace RoomBooking.Data
{
    public class DemoBookingRepository : IBookingRepository
    {
        public List<Booking> GetAll()
        {
            return new List<Booking>
            {
                new Booking { Id = 6, Room = "288",Hour = 21 }
            };
        }
    }
}
