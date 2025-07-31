using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.ChainOfResponsibility.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.ChainOfResponsibility
{
    public class GameTests
    {
        [Fact]
        public void Should_Calculate_Stats_For_Single_Goblin()
        {
            // Arrange
            Game game = new();
            Goblin goblin = new(game);

            // Act
            game.Creatures.Add(goblin);

            // Assert
            Assert.Equal(1, goblin.Attack);
            Assert.Equal(1, goblin.Defense);
        }

        [Fact]
        public void Should_Calculate_Stats_For_Single_Goblin_King()
        {
            // Arrange
            Game game = new();
            GoblinKing goblinKing = new(game);

            // Act
            game.Creatures.Add(goblinKing);

            // Assert
            Assert.Equal(3, goblinKing.Attack);
            Assert.Equal(3, goblinKing.Defense);
        }

        [Fact]
        public void Should_Calculate_Stats_For_3_Goblins()
        {
            // Arrange
            Game game = new();
            int goblinsCount = 3;

            // Act
            for (int i = 0; i < goblinsCount; i++)
                game.Creatures.Add(new Goblin(game));

            // Assert
            for (int i = 0; i < goblinsCount; i++)
            {
                Assert.Equal(1, game.Creatures[i].Attack);
                Assert.Equal(3, game.Creatures[i].Defense);
            }
        }

        [Fact]
        public void Should_Calculate_Stats_For_3_Goblins_And_1_King()
        {
            // Arrange
            Game game = new();
            int goblinsCount = 3;

            // Act
            for (int i = 0; i < goblinsCount; i++)
                game.Creatures.Add(new Goblin(game));

            GoblinKing king = new(game);
            game.Creatures.Add(king);

            // Assert
            for (int i = 0; i < goblinsCount; i++)
            {
                Assert.Equal(2, game.Creatures[i].Attack);
                Assert.Equal(4, game.Creatures[i].Defense);
            }
            Assert.Equal(3, king.Attack);
            Assert.Equal(3 + goblinsCount, king.Defense);
        }
    }
}
