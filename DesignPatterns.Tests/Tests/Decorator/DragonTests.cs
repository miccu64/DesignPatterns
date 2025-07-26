using DesignPatterns.Decorator;
using Xunit;

namespace DesignPatterns.Tests.Tests.Decorator
{
    public class DragonTests
    {
        [Fact]
        public void Should_Properly_Create()
        {
            // Arrange
            const int age = 10;
            Dragon dragon = new() { Age = age };

            // Act
            string fly = dragon.Fly();
            string crawl = dragon.Crawl();

            // Assert
            Assert.NotEmpty(fly);
            Assert.NotEmpty(crawl);
            Assert.Equal(age, dragon.Age);
        }
    }
}
