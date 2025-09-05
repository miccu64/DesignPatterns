using DesignPatterns.NullObject;
using DesignPatterns.NullObject.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.NullObject
{
    public class AccountTests
    {
        [Fact]
        public void Should_Not_Throw_On_Single_Call()
        {
            // Arrange
            NullLog log = new();
            Account account = new(log);

            // Act 
            var exception = Record.Exception(() => account.SomeOperation());

            // Assert
            Assert.Null(exception);
        }

        [Fact]
        public void Should_Not_Throw_On_Many_Calls()
        {
            // Arrange
            NullLog log = new();
            Account account = new(log);

            // Act 
            var exception = Record.Exception(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    account.SomeOperation();
                }
            });

            // Assert
            Assert.Null(exception);
        }
    }
}
