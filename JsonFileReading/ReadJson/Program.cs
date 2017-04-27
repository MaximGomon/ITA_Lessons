using System;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ReadJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileText = File.ReadAllText(@"..\..\source.json");

            SourceJson element = JsonConvert.DeserializeObject<SourceJson>(fileText);
            string serializedElement = JsonConvert.SerializeObject(element, Formatting.Indented);

            File.WriteAllText(@"..\..\new_json.json", serializedElement);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SourceJson));

            using (var stream = new FileStream(@"..\..\source.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(stream, element);
            }

            SourceJson xmlSource = (SourceJson)xmlSerializer.Deserialize(new FileStream(@"..\..\source.xml", FileMode.Open));

            Console.WriteLine("Complete successeful");
            Thread.Sleep(1000);
        }
    }
}