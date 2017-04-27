using System.Runtime.Serialization;

namespace ReadJson
{
    [DataContract]
    public class SourceJson
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name="properties")]
        public Properties Property { get; set; }
    }
}
