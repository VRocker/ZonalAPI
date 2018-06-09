using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class StyleRequest : RequestBase
    {
        public StyleRequest()
            : base()
        {
            Method = "style";
        }
    }
}
