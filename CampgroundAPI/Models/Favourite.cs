namespace CampgroundAPI.Models
{
    public class Favourite
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public Campground? Campground { get; set; }
    }
}
