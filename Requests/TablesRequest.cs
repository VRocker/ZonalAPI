using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class TablesRequest : VenueRequestBase
    {
        public TablesRequest()
            : base()
        {
            Method = "getTables";
        }

        [DataMember(Name = "salesAreaId", IsRequired = true)]
        public int SalesAreaID { get; set; }
    }
}
