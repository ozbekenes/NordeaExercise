using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace NordeaFormatter
{
    public  class CSVFormatter : IFormatter
    {
        public string Format(List<Sentence> items)
        {
            var stringBuilder = new StringBuilder();
            var header = Enumerable.Range(1, items.Max(p => p.Words.Count)).Select(p => string.Format(", Word {0}", p));
            stringBuilder.AppendLine(string.Join("", header));

            for (int i = 0; i < items.Count; i++)
            {
                stringBuilder.AppendLine(string.Format("Sentence {0}, ", i + 1) + string.Join(", ", items[i].Words));
            }
            return stringBuilder.ToString().Trim();
        }
    }
}
