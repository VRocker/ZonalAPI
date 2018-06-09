using System.Runtime.Serialization;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class OpeningTimesRequest : VenueRequestBase
    {
        public OpeningTimesRequest()
            : base()
        {
            Method = "opening";
        }
    }
}
