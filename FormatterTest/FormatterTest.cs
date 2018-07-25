using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using NordeaFormatter;
using System.Collections.Generic;
using System.Linq;

namespace NordeaFormatterTest
{
    [TestClass]
    public class FormatterTest
    {
        [TestMethod]
        public void FormattingText_WithSimpleSentences_Valid()
        {
            //Arrange
            var formatter = new Formatter();
            var expected = new List<Sentence>
            {
                new Sentence { Words = new List<string> { "a", "had", "lamb", "little", "Mary" } },
                new Sentence { Words = new List<string> { "Aesop", "and", "called", "came", "for", "Peter", "the", "wolf" } }
            };
            var actual = new List<Sentence>();
            string input = "Mary had a little lamb. Peter called for the wolf, and Aesop came.";

            //Act
            actual = formatter.Format(input);
            var itemsExpected = expected.SelectMany(p => p.Words).ToList();
            var itemsActual = actual.SelectMany(p => p.Words).ToList();

            //Assert
            itemsExpected.Should().Equal(itemsActual);
        }

        [TestMethod]
        public void FormattingText_WithMultipleSpaces_Valid()
        {
            //Arrange
            Formatter formatter = new Formatter();
            var expected = new List<Sentence>
            {
                new Sentence { Words = new List<string> { "a", "had", "lamb", "little", "Mary" } },
                new Sentence { Words = new List<string> { "Aesop", "and", "called", "came", "for", "Peter", "the", "wolf" } }
            };
            var actual = new List<Sentence>();
            string input = "Mary had a little lamb. \n \n Peter called for the wolf, and Aesop came.";

            //Act
            actual = formatter.Format(input);
            var itemsExpected = expected.SelectMany(p => p.Words).ToList();
            var itemsActual = actual.SelectMany(p => p.Words).ToList();

            //Assert
            itemsExpected.Should().Equal(itemsActual);
        }
    }
}