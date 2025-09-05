using DesignPatterns.TemplateMethod;
using DesignPatterns.TemplateMethod.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.TemplateMethod
{
    public class PermanentCardDamageGameTests
    {
        [Fact]
        public void Only_Creature2_Should_Survive_After_2_Rounds()
        {
            // Arrange
            const int attack = 1;
            const int creature1Health = 2;
            const int creature2Health = 3;
            Creature creature1 = new(attack, creature1Health);
            Creature creature2 = new(attack, creature2Health);
            PermanentCardDamageGame game = new([creature1, creature2]);

            const int creature2Index = 1;

            // Act
            int round1 = game.Combat(0, 1);
            int round2 = game.Combat(0, 1);

            // Assert
            Assert.Equal(-1, round1);
            Assert.Equal(creature2Index, round2);

            Assert.Equal(creature1Health - (attack * 2), creature1.Health);
            Assert.Equal(creature2Health - (attack * 2), creature2.Health);
        }


        [Fact]
        public void Should_Both_Creatures_Die()
        {
            // Arrange
            const int attack = 2;
            const int health = 2;
            Creature creature1 = new(attack, health);
            Creature creature2 = new(attack, health);
            PermanentCardDamageGame game = new([creature1, creature2]);

            // Act
            int round1 = game.Combat(0, 1);

            // Assert
            Assert.Equal(-1, round1);

            Assert.Equal(health - attack, creature1.Health);
            Assert.Equal(health - attack, creature2.Health);
        }
    }
}
