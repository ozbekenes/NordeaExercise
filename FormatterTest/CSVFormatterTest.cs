using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NordeaFormatter;
using FluentAssertions;
namespace FormatterTest
{
    [TestClass]
    public class CSVFormatterTest
    {
        [TestMethod]
        public void CSVFormatting_WithValidInput_ThenOK()
        {
            //Arrange

            var input = new List<Sentence>
            {
                new Sentence { Words = new List<string> { "a", "had", "lamb", "little", "Mary" } },
                new Sentence { Words = new List<string> { "Aesop", "and", "called", "came", "for", "Peter", "the", "wolf" } }
            };

            var expected = @", Word 1, Word 2, Word 3, Word 4, Word 5, Word 6, Word 7, Word 8
Sentence 1, a, had, lamb, little, Mary
Sentence 2, Aesop, and, called, came, for, Peter, the, wolf";

            //Act
            var actual = CSVFormatter.Write(input);

            //Assert
            expected.Should().BeEquivalentTo(actual);
        }
    }
}
