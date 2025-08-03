using DesignPatterns.Command;
using DesignPatterns.Command.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Command
{
    public class AccountTests
    {
        [Fact]
        public void Should_Deposit()
        {
            // Arrange
            const int initialBalance = 10;
            Account account = new()
            {
                Balance = initialBalance
            };
            const int amountToDeposit = 55;
            CommandInfo command = new()
            {
                Amount = amountToDeposit,
                Action = ActionType.Deposit
            };

            // Act
            account.Process(command);

            // Assert
            Assert.True(command.Success);
            Assert.Equal(initialBalance + amountToDeposit, account.Balance);
        }

        [Fact]
        public void Should_Withdraw()
        {
            // Arrange
            const int initialBalance = 10;
            Account account = new()
            {
                Balance = initialBalance
            };
            const int amountToWithdraw = 5;
            CommandInfo command = new()
            {
                Amount = amountToWithdraw,
                Action = ActionType.Withdraw
            };

            // Act
            account.Process(command);

            // Assert
            Assert.True(command.Success);
            Assert.Equal(initialBalance - amountToWithdraw, account.Balance);
        }

        [Fact]
        public void Should_Not_Withdraw_When_Account_Amount_Is_Too_Low()
        {
            // Arrange
            const int initialBalance = 5;
            Account account = new()
            {
                Balance = initialBalance
            };
            const int amountToWithdraw = 10;
            CommandInfo command = new()
            {
                Amount = amountToWithdraw,
                Action = ActionType.Withdraw
            };

            // Act
            account.Process(command);

            // Assert
            Assert.False(command.Success);
            Assert.Equal(initialBalance, account.Balance);
        }
    }
}
