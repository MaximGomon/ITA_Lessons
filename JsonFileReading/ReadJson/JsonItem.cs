using System.Runtime.Serialization;

namespace ReadJson
{
    [DataContract]
    public class JsonItem
    {
        [DataMember(Name = "ref")]
        public bool Referenced { get; set; }
    }
}