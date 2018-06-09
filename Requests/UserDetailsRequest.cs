using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class UserDetailsRequest : RequestBase
    {
        public UserDetailsRequest()
            : base()
        {
            Method = "userDetails";
        }

        [DataMember(Name = "venueId")]
        public int VenueID { get; set; } = -1;
    }
}
