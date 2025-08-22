using DesignPatterns.Memento;
using DesignPatterns.Memento.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Memento
{
    public class TokenMachineTests
    {
        [Fact]
        public void Should_Hold_Single_Token()
        {
            // Arrange
            TokenMachine machine = new();
            Token token = new(111);

            // Act
            machine.AddToken(token);

            // Assert
            Assert.Single(machine.Tokens);
            Assert.Equal(token.Value, machine.Tokens[0].Value);
        }

        [Fact]
        public void Should_Hold_Few_Tokens()
        {
            // Arrange
            TokenMachine machine = new();
            const int tokensCount = 5;

            // Act
            for (int i = 0; i < tokensCount; i++)
                machine.AddToken(new Token(i));

            // Assert
            Assert.Equal(tokensCount, machine.Tokens.Count);

            for (int i = 0; i < tokensCount; i++)
                Assert.Equal(i, machine.Tokens[i].Value);
        }

        [Fact]
        public void Should_Keep_Old_Value_In_Machine_After_Change_In_Referenced_Token()
        {
            // Arrange
            TokenMachine machine = new();
            const int initialValue = 111;
            Token token = new(initialValue);

            // Act
            machine.AddToken(token);
            token.Value = 33;

            // Assert
            Assert.Equal(initialValue, machine.Tokens[0].Value);
        }

    }
}
