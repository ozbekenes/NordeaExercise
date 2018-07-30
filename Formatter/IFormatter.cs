using System;
using System.Collections.Generic;
using System.Text;

namespace NordeaFormatter
{
    public interface IFormatter
    {
        string Format(List<Sentence> items);
    }
}
