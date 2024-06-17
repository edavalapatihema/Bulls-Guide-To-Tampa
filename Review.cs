using Newtonsoft.Json;


namespace BullsRideToTampa.Models
{
    public class Review
    {
        public string ReviewId { get; set; }
        public string BusinessId { get; set; }
        public int Rating { get; set; }
        public string ReviewedBy { get; set; }
    }

}
