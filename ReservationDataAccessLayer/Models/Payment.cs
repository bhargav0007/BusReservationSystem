namespace ReservationDataAccessLayer.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public long BookingId { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }

        public Booking Booking { get; set; }
    }
}
