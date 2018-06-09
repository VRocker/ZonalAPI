using System.Runtime.Serialization;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class MenusRequest : VenueRequestBase
    {
        public MenusRequest()
            : base()
        {
            Method = "getMenus";
        }

        [DataMember(Name = "salesAreaId", IsRequired = true)]
        public int SalesAreaID { get; set; }
    }
}
