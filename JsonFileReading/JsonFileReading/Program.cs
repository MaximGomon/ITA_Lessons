using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace JsonFileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            var ser = new DataContractJsonSerializer(typeof (Order), new List<Type>
            {
                typeof(SearchDump),
                typeof(Product)
            });
            Order order = (Order)ser.ReadObject(new FileStream(@"D:\new.json", FileMode.Open, FileAccess.Read));

            var xmlSerializer = new XmlSerializer(typeof(Order), new Type[]
            {
                typeof(SearchDump),
                typeof(Product)
            });
            using (var fileStream = new FileStream(@"D:\MyXml.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, order);
            }
            Order obj = (Order)xmlSerializer.Deserialize(
                new FileStream(@"D:\MyXml.xml", FileMode.Open));
            Console.ReadKey();
        }
    }
}
