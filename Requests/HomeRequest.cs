using System.Runtime.Serialization;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class HomeRequest : VenueRequestBase
    {
        public HomeRequest()
            : base()
        {
            Method = "home";
        }
    }
}
