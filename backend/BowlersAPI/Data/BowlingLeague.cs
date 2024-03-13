using System.ComponentModel.DataAnnotations;

namespace BowlersAPI.Data
{
    public class BowlingLeague
    {
        [Key]
        public int BowlerId { get; set; }
        public string BowlerName { get; set; }
        public string TeamName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PhoneNumber { get; set; }
    }
}
