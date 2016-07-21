using System.Runtime.Serialization;

namespace JsonFileReading
{
    [DataContract]
    public class SearchDump
    {
        [DataMember(Name = "product")]
        public Product Product { get; set; }
    }
}