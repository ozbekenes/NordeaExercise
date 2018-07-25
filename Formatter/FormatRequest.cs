using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace NordeaFormatter
{
    public enum FormatType
    {
        [XmlEnum("XML")]
        XML,
        [XmlEnum("CSV")]
        CSV
    }
    public class FormatRequest
    {
        public string InputText { get; set; }
        public FormatType FormatType { get; set; }
    }
}
