namespace ReservationDataAccessLayer.Models
{
    public class Booking
    {
        public long Id { get; set; }
        public long BusId { get; set; }
        public long UserId { get; set; }
        public long ScheduleId { get; set; }
        public DateTime BookingDate { get; set; }

        // Numbers of SeatsBooked
        public int TotalSeats { get; set; }

        // Confirmed, Pending, Cancelled
        public string Status { get; set; }
        public Bus Bus { get; set; }
        public User User { get; set; }
        public Schedule Schedule { get; set; }
    }
}
