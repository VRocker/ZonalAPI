using System.Runtime.Serialization;

namespace ZonalAPI.Responses
{
    namespace Menus
    {
        [DataContract]
        public class MenusResponse : ResponseBase
        {
            [DataMember(Name = "platform")]
            public string Platform { get; set; }
            [DataMember(Name = "canPlaceOrder")]
            public int CanPlaceOrder { get; set; }
            [DataMember(Name = "waitTime")]
            public int WaitTime { get; set; }
            [DataMember(Name = "hasAztecCourses", IsRequired = false)]
            public string HasAztecCourses { get; set; }
            [DataMember(Name = "menus")]
            public Menu[] Menus { get; set; }
            [DataMember(Name = "count")]
            public int Count { get; set; }
            [DataMember(Name = "courses")]
            public Course[] Courses { get; set; }
        }

        [DataContract]
        public class Menu
        {
            [DataMember(Name = "sortOrder")]
            public int SortOrder { get; set; }
            [DataMember(Name = "created")]
            public string Created { get; set; }
            [DataMember(Name = "image")]
            public string Image { get; set; }
            [DataMember(Name = "canOrder")]
            public int CanOrder { get; set; }
            [DataMember(Name = "description")]
            public string Description { get; set; }
            [DataMember(Name = "updated")]
            public string Updated { get; set; }
            [DataMember(Name = "id")]
            public int ID { get; set; }
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }

        [DataContract]
        public class Course
        {
            [DataMember(Name = "displayName")]
            public string DisplayName { get; set; }
            [DataMember(Name = "sortOrder")]
            public int SortOrder { get; set; }
            [DataMember(Name = "id")]
            public int ID { get; set; }
        }

    }
}