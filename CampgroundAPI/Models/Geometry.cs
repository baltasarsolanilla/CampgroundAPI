namespace CampgroundAPI.Models
{
    public class Geometry
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Latitud { get; set; } = string.Empty;
        public string Longitud { get; set; } = string.Empty;
    }
}