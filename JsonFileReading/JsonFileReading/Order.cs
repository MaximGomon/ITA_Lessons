using System.Runtime.Serialization;

namespace JsonFileReading
{
    [DataContract]
    public class Order
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "startdate")]
        public string StartDate { get; set; }
        [DataMember(Name = "enddate")]
        public string EndDate { get; set; }
        [DataMember(Name = "promocode")]
        public string PromoCode { get; set; }
        [DataMember(Name = "promovalue")]
        public double PromoValue { get; set; }
        [DataMember(Name = "fio")]
        public string Fio { get; set; }
        //[DataMember(Name = "search_dump")]
        //public SearchDump SearchDump { get; set; }
        public override string ToString()
        {
            return $"{Fio} {Id} Start date:{StartDate}";
        }
    }
}