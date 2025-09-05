using DesignPatterns.TemplateMethod;
using DesignPatterns.TemplateMethod.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.TemplateMethod
{
    public class TemporaryCardDamageGameTests
    {
        [Fact]
        public void Should_Both_Creatures_Survive()
        {
            // Arrange
            const int creature1Health = 2;
            const int creature2Health = 3;
            Creature creature1 = new(1, creature1Health);
            Creature creature2 = new(1, creature2Health);
            TemporaryCardDamageGame game = new([creature1, creature2]);

            // Act
            int round1 = game.Combat(0, 1);

            // Assert
            Assert.Equal(-1, round1);

            Assert.Equal(creature1Health, creature1.Health);
            Assert.Equal(creature2Health, creature2.Health);
        }

        [Fact]
        public void Should_Both_Creatures_Die()
        {
            // Arrange
            const int attack = 2;
            const int health = 2;
            Creature creature1 = new(attack, health);
            Creature creature2 = new(attack, health);
            TemporaryCardDamageGame game = new([creature1, creature2]);

            // Act
            int round1 = game.Combat(0, 1);

            // Assert
            Assert.Equal(-1, round1);

            Assert.Equal(health - attack, creature1.Health);
            Assert.Equal(health - attack, creature2.Health);
        }
    }
}
