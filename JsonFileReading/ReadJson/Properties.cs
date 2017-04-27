using System.Runtime.Serialization;

namespace ReadJson
{
    [DataContract]
    public class Properties
    {
        [DataMember(Name = "Errors")]
        public Error Error { get; set; }
        [DataMember(Name = "NextTier")]
        public Tier[] Tier { get; set; } 
    }
}