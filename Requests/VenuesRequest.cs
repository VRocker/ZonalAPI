using System.Runtime.Serialization;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class VenuesRequest : VenueRequestBase
    {
        public VenuesRequest()
            : base()
        {
            Method = "venues";
        }       
    }
}
