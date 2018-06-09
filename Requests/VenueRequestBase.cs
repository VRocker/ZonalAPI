using System.Runtime.Serialization;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class VenueRequestBase : RequestBase
    {
        public VenueRequestBase()
            : base()
        {
        }

        [DataMember(Name = "venueId")]
        public int VenueID { get; set; } = -1;
        [DataMember(Name = "siteId")]
        public int SiteID { get; set; } = -1;
    }
}
