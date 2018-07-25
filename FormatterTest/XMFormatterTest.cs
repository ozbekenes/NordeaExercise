using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NordeaFormatter;
using FluentAssertions;

namespace FormatterTest
{
    [TestClass]
    public class XMFormatterTest
    {
        [TestMethod]
        public void XMLFormatting_WithValidInput_ThenOk()
        {
            //Arrange
            var input = new List<Sentence>
            {
                new Sentence { Words = new List<string> { "a", "had", "lamb", "little", "Mary" } },
                new Sentence { Words = new List<string> { "Aesop", "and", "called", "came", "for", "Peter", "the", "wolf" } }
            };

            var expected = @"<?xml version=""1.0"" encoding=""utf-16""?>
<Text>
  <Sentence>
    <Word>a</Word>
    <Word>had</Word>
    <Word>lamb</Word>
    <Word>little</Word>
    <Word>Mary</Word>
  </Sentence>
  <Sentence>
    <Word>Aesop</Word>
    <Word>and</Word>
    <Word>called</Word>
    <Word>came</Word>
    <Word>for</Word>
    <Word>Peter</Word>
    <Word>the</Word>
    <Word>wolf</Word>
  </Sentence>
</Text>";
            //Act
            var actual = XMLFormatter.Write(input);

            //Assert
            expected.Should().BeEquivalentTo(actual);
        }
    }
}
