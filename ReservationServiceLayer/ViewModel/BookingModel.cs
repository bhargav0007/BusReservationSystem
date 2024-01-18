using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationServiceLayer.ViewModel
{
    public class BookingModel
    {
        public string BusName { get; set; }
        public string UserName { get; set; }
        public DateTime BookingDate { get; set; }

        // Numbers of SeatsBooked
        public int TotalSeats { get; set; }

        // Confirmed, Pending, Cancelled
        public string Status { get; set; }
    }
}
