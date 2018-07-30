using System;
using System.Collections.Generic;
using System.Text;

namespace NordeaFormatter
{
    public class GenericFormatter
    {
        public IFormatter Create(FormatType type)
        {
            IFormatter convertor = null;
            if (type == FormatType.XML) convertor = new XMLFormatter();
            if (type == FormatType.CSV) convertor = new CSVFormatter();
            return convertor;
        }
    }
}
