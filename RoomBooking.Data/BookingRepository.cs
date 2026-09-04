using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RoomBooking.Data
{
    public class BookingRepository
    {
        private readonly List<Booking> _items = new()
        {
            new Booking { Id = 1, Room = "132", Hour = 12 },
            new Booking { Id = 2, Room = "475", Hour = 13 },
            new Booking { Id = 3, Room = "206", Hour = 16 },
            new Booking { Id = 4, Room = "229", Hour = 17 },
            new Booking { Id = 5, Room = "107", Hour = 20 }
        };
        public List<Booking> GetAll()
        {
            return _items;
        }

    }
}
