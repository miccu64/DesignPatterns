using DesignPatterns.Flyweight;
using Xunit;

namespace DesignPatterns.Tests.Tests.Flyweight
{
    public class SentenceTests
    {
        [Fact]
        public void Should_Capitalize_Second_Word()
        {
            // Arrange
            Sentence sentence = new("hello world");

            // Act
            sentence[1].Capitalize = true;
            string result = sentence.ToString();

            // Assert
            Assert.Equal("hello WORLD", result);
        }
    }
}
