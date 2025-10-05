using DesignPatterns.Observer;
using DesignPatterns.Observer.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Observer
{
    public class GameTests
    {
        [Fact]
        public void Single_Rat()
        {
            // Arrange
            Game game = new();

            // Act
            Rat rat = new(game);

            // Assert
            Assert.Equal(1, rat.Attack);
        }

        [Fact]
        public void Two_Rats()
        {
            // Arrange
            Game game = new();

            // Act
            List<Rat> rats =
            [
                new Rat(game),
                new Rat(game)
            ];

            // Assert
            foreach (Rat rat in rats)
            {
                Assert.Equal(rats.Count, rat.Attack);
            }
        }

        [Fact]
        public void Three_Rats_One_Dies()
        {
            // Arrange
            Game game = new();

            // Act
            List<Rat> aliveRats =
            [
                new Rat(game),
                new Rat(game)
            ];

            Rat dyingRat = new(game);
            dyingRat.Dispose();

            // Assert
            foreach (Rat rat in aliveRats)
            {
                Assert.Equal(aliveRats.Count, rat.Attack);
            }
        }
    }
}
