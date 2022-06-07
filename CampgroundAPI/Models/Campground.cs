namespace CampgroundAPI.Models
{
    public class Campground
    {
        public int Id { get; set; } 
        public string Type { get; set; } = string.Empty;
        public Geometry? Geometry { get; set; } = null;
        public Property? Property { get; set; } = null;

    }
}
