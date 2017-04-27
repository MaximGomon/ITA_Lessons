using System.Runtime.Serialization;

namespace ReadJson
{
    [DataContract]
    public class Tier
    {
        [DataMember(Name = "type")]
        public int Number { get; set; }
    }
}