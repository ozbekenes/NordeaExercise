using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NordeaFormatter
{
    public class Sentence
    {
        [XmlElement("Word")]
        public List<string> Words { get; set; }
    }

    /// <summary>
    /// create for proper xml format.
    /// </summary>
    [XmlRoot("Text")]
    public class TestObjects : List<Sentence>
    {

    }
}
