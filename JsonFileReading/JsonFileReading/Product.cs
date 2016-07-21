using System.Runtime.Serialization;

namespace JsonFileReading
{
    [DataContract]
    public class Product
    {
        [DataMember(Name = "sys")]
        public string Sys { get; set; }
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "short")]
        public string Short { get; set; } 
    }
}