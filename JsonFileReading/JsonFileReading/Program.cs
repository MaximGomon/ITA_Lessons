using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JsonFileReading
{
    class Program
    {
        static void Main(string[] args)
        {
            //var intLIst = Extensions.CreateList<int>();
            var stringList = Extensions.CreateList<string>();

            //string myInput = "Hello.My name";
            //Console.WriteLine(myInput.GetLastAfterPoint());
            //Console.ReadKey();
            Order simple = JsonConvert.DeserializeObject<Order>(File.ReadAllText(@"D:\new.json"));

            File.WriteAllText(@"D:\My.json", JsonConvert.SerializeObject(simple));

            var ser = new DataContractJsonSerializer(typeof (Order));

            Console.WriteLine(simple);

            Order order = (Order)ser.ReadObject(new FileStream(@"D:\new.json", 
                FileMode.Open, FileAccess.Read));

            var xmlSerializer = new XmlSerializer(typeof(Order));

            using (var fileStream = new FileStream(@"D:\MyXml.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, order);
            }

            Order obj = (Order)xmlSerializer.Deserialize(
                new FileStream(@"D:\MyXml.xml", FileMode.Open));
            Console.ReadKey();
        }

        private static List<Order> GreateList()
        {
            return new List<Order>();
        } 


    }
}
