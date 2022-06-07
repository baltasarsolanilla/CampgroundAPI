namespace CampgroundAPI.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string ASSET_DESC { get; set; } = string.Empty;
        public string ASSET_OWNE { get; set; } = string.Empty;
        public string HERITAGE_V { get; set; } = string.Empty;
        public string MGA_EASTIN { get; set; } = string.Empty;

        public string MGA_NORTHI { get; set; } = string.Empty;
        public string MGA_ZONE { get; set; } = string.Empty;
        public string PARK_ID { get; set; } = string.Empty;
        public string PARK_NAME { get; set; } = string.Empty;
        public string SITE_NAME { get; set; } = string.Empty;
     }
}