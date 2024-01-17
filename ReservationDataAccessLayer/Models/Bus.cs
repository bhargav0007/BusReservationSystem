namespace ReservationDataAccessLayer.Models
{
    public class Bus
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }

        public List<Schedule> Schedules { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
