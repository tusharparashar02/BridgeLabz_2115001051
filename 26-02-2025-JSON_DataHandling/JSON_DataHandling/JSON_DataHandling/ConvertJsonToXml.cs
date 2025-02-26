using System;
using Newtonsoft.Json;
using System.IO;
using System.Xml;

namespace JSON_DataHandling
{
    class ConvertJsonToXml
    {
        public static void Convert(string jsonFilePath)
        {
            string json = File.ReadAllText(jsonFilePath);
            XmlDocument xml = JsonConvert.DeserializeXmlNode(json, "Root");

            Console.WriteLine(xml.OuterXml);
        }
    }
}
