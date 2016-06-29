using System.Runtime.Serialization;

namespace WF2
{
    [DataContract]
    public abstract class Bike
    {
        [DataMember]
        public int Id;
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Size { get; set; }

        protected Bike(int id)
        {
            Id = id;
        }

        protected Bike()
        {
            
        }
    }
}