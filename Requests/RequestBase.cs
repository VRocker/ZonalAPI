using System.Runtime.Serialization;

namespace ZonalAPI.Requests
{
    [DataContract]
    public class RequestBase
    {
        [DataMember(Name = "username", IsRequired = true)]
        public string Username { get; set; }

        [DataMember(Name ="password", IsRequired = true)]
        public string Password { get; set; }

        [DataMember(Name ="version", IsRequired = true)]
        public string Version { get; set; }

        [DataMember(Name = "platform", IsRequired = true)]
        public string Platform { get; set; } = "Android";

        [DataMember(Name = "userDeviceIdentifier")]
        public string UserDeviceIdentifier { get; set; }

        [DataMember(Name = "method", IsRequired = true)]
        public string Method { get; set; }

        [DataMember(Name = "bundleIdentifier", IsRequired = true)]
        public string BundleIdentifier { get; set; }
    }
}
