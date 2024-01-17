namespace ReservationDataAccessLayer.Models
{
    public class Schedule
    {
        public long Id { get; set; }
        public long BusId { get; set; }
        public long RouteId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AvailableSeats { get; set; }

        public Bus Bus { get; set; }
        public Route Route { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
