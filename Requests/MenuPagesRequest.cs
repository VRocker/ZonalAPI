using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class MenuPagesRequest : VenueRequestBase
    {
        public MenuPagesRequest()
        {
            Method = "getmenupages";
        }

        [DataMember(Name = "salesAreaId", IsRequired = true)]
        public int SalesAreaID { get; set; }

        [DataMember(Name = "menuId", IsRequired = true)]
        public int MenuID { get; set; }
    }
}
