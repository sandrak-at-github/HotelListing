using Microsoft.Build.Framework;

namespace HotelListing.API.Models.Country
{
    public abstract class BaseCountryDto
    {
        [Required]  // validation doesn't run when you are getting data
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
