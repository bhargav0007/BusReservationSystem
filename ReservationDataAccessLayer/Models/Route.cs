
namespace ReservationDataAccessLayer.Models
{
    public class Route
    {
        public long Id { get; set; }
        public string SourceCity { get; set; }
        public string DestinationCity { get; set; }
        public string Duration { get; set; }
        public int Distance { get; set; }

        public List<Schedule> Schedules { get; set; }


    }
}
