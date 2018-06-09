using System.Runtime.Serialization;

namespace ZonalAPI.Requests
{
    [DataContract]

    public class ApiRequest<T>
    {
        [DataMember(Name = "request", IsRequired = true)]
        public T Request { get; set; }
    }
}
