using DesignPatterns.Mediator;
using DesignPatterns.Mediator.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Mediator
{
    public class ParticipantMediatorTests
    {
        [Fact]
        public void Two_Participants_Send_Each_One_Message()
        {
            // Arrange
            ParticipantMediator mediator = new();
            Participant participant1 = new(mediator);
            Participant participant2 = new(mediator);

            const int say1 = 3;
            const int say2 = 2;

            // Act
            participant1.Say(say1);
            participant2.Say(say2);

            // Assert
            Assert.Equal(say2, participant1.Value);
            Assert.Equal(say1, participant2.Value);
        }
    }
}
