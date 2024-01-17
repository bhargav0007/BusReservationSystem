namespace ReservationDataAccessLayer.Models
{
    public class User
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string? FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }


        public List<Booking> Bookings { get; set; }

    }
}
