namespace HotelListing.API.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }


        // One-To-Many association with Hotel
        public virtual IList<Hotel> Hotels { get; set; }

    }
}