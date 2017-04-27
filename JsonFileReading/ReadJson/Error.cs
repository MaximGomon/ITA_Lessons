using System.Runtime.Serialization;

namespace ReadJson
{
    [DataContract]
    public class Error
    {
        [DataMember(Name = "type")]
        public string[] Types { get; set; }
        [DataMember(Name = "items")]
        public JsonItem Item { get; set; }
    }
}