using System.Runtime.Serialization;

namespace ZonalAPI.Responses
{
    namespace Opening
    {
        [DataContract]
        public class OpeningResponse : ResponseBase
        {
            [DataMember(Name = "count")]
            public int Count { get; set; }
            [DataMember(Name = "id")]
            public int ID { get; set; }
            [DataMember(Name = "openingTimes")]
            public Openingtime[] openingTimes { get; set; }
        }

        [DataContract]
        public class Openingtime
        {
            [DataMember(Name = "openingTime")]
            public string OpeningTime { get; set; }
            [DataMember(Name = "closed")]
            public int Closed { get; set; }
            [DataMember(Name = "shortLabel")]
            public string ShortLabel { get; set; }
            [DataMember(Name = "label")]
            public string Label { get; set; }
            [DataMember(Name = "closingTime")]
            public string ClosingTime { get; set; }
            [DataMember(Name = "id")]
            public int ID { get; set; }
        }
    }
}
