using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NordeaFormatter
{
    public class XMLFormatter : IFormatter
    {

        public string Format(List<Sentence> items)
        {
            TestObjects test = new TestObjects();
            test.AddRange(items);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TestObjects));
            XmlSerializerNamespaces nameSpace = new XmlSerializerNamespaces();
            nameSpace.Add("", "");
            var xml = "";
            var settings = new XmlWriterSettings
            {
                Indent = true,
                NewLineOnAttributes = true
            };
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww, settings))
                {
                    xmlSerializer.Serialize(writer, test, nameSpace);
                    xml = sww.ToString();
                }
            }
            return xml;
        }
    }
}
