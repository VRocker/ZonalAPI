using System.Runtime.Serialization;

namespace ZonalAPI.Responses
{
    [DataContract]
    public class ResponseBase
    {
        [DataMember(Name = "response")]
        public string Response { get; set; }
    }
}
