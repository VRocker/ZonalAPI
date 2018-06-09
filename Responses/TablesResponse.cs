using System.Runtime.Serialization;

namespace ZonalAPI.Responses
{
    namespace Tables
    {
        [DataContract]
        public class TablesResponse : ResponseBase
        {
            [DataMember(Name = "salesAreaId")]
            public int SalesAreaId { get; set; }
            [DataMember(Name = "count")]
            public int Count { get; set; }
            [DataMember(Name = "siteId")]
            public int SiteId { get; set; }
            [DataMember(Name = "estateId")]
            public int EstateId { get; set; }
            [DataMember(Name = "tables")]
            public Table[] Tables { get; set; }
        }

        [DataContract]
        public class Table
        {
            [DataMember(Name = "number")]
            public int Number { get; set; }
            [DataMember(Name = "id")]
            public int ID { get; set; }
        }

    }
}
