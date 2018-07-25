using System;
using System.Collections.Generic;
using System.Linq;

namespace NordeaFormatter
{

    public class Formatter
    {
        private char[] _sentenceDelimiters = { '.', '?', '!' };

        public List<Sentence> Format(string input)
        {
            List<Sentence> formattedSentences = new List<Sentence>();
            var sentences = input.Split(_sentenceDelimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in sentences)
            {
                var punctuation = item.Where(Char.IsPunctuation).Distinct().ToArray();
                var words = item.Split().Select(x => x.Trim(punctuation)).Where(p=>!string.IsNullOrWhiteSpace(p)).OrderBy(p => p).ToList();

                if (words.Any())
                {
                    formattedSentences.Add(new Sentence { Words = words });
                }
            }
            return formattedSentences;
        }
    }
}
