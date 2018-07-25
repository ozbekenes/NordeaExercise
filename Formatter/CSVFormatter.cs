using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace NordeaFormatter
{
    public static class CSVFormatter
    {
        public static string Write(List<Sentence> sentences)
        {
            var stringBuilder = new StringBuilder();
            var header = Enumerable.Range(1, sentences.Max(p => p.Words.Count)).Select(p => string.Format(", Word {0}", p));
            stringBuilder.AppendLine(string.Join("", header));

            for (int i = 0; i < sentences.Count; i++)
            {
                stringBuilder.AppendLine(string.Format("Sentence {0}, ", i + 1) + string.Join(", ", sentences[i].Words));
            }
            return stringBuilder.ToString().Trim();
        }
    }
}
