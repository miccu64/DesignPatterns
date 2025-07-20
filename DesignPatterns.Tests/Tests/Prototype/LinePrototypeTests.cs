using DesignPatterns.Prototype;
using DesignPatterns.Prototype.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Prototype
{
    public class LinePrototypeTests
    {
        [Fact]
        public void Should_Create_Deep_Copy()
        {
            // Arrange
            Point point = new()
            {
                X = 1,
                Y = 2
            };
            LinePrototype line = new()
            {
                Start = point,
                End = point,
                Name = "SomeName"
            };

            // Act
            LinePrototype copy = line.DeepCopy();

            // Assert
            Assert.NotSame(line, copy);
            Assert.NotSame(line.Start, copy.Start);
            Assert.NotSame(line.End, copy.End);
            Assert.Equal(line.Name, copy.Name);
        }
    }
}
