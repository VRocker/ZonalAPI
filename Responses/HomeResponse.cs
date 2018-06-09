using System.Runtime.Serialization;

namespace ZonalAPI.Responses
{
    namespace Home
    {
        [DataContract]
        public class HomeResponse : ResponseBase
        {
            public string platform { get; set; }
            [DataMember(Name = "banners")]
            public Banner[] Banners { get; set; }
            [DataMember(Name = "header")]
            public Header Header { get; set; }
        }

        [DataContract]
        public class Header
        {
            [DataMember(Name = "images")]
            public Image[] Images { get; set; }
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }

        [DataContract]
        public class Image
        {
            [DataMember(Name = "device")]
            public string Device { get; set; }
            [DataMember(Name = "url")]
            public string URL { get; set; }
        }

        [DataContract]
        public class Banner
        {
            [DataMember(Name = "sortOrder")]
            public int SortOrder { get; set; }
            [DataMember(Name = "images")]
            public Image[] Images { get; set; }
            [DataMember(Name = "link")]
            public string Link { get; set; }
            [DataMember(Name = "title")]
            public string Title { get; set; }
            [DataMember(Name = "id")]
            public int ID { get; set; }
        }
    }
}
