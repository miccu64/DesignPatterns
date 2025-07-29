using DesignPatterns.Proxy;
using DesignPatterns.Proxy.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Proxy
{
    public class ResponsiblePersonTests
    {
        [Fact]
        public void Age_Should_Match()
        {
            // Arrange
            Person person = new() { Age = 33 };
            ResponsiblePerson responsiblePerson = new(person);

            // Act / Assert
            Assert.Equal(person.Age, responsiblePerson.Age);
        }

        [Fact]
        public void Proxy_Should_Change_Results_According_To_Age()
        {
            // Arrange
            Person person = new() { Age = 15 };
            ResponsiblePerson responsiblePerson = new(person);

            // Act / Assert
            Assert.NotEqual(person.Drink(), responsiblePerson.Drink());
            Assert.NotEqual(person.Drive(), responsiblePerson.Drive());
            Assert.NotEqual(person.DrinkAndDrive(), responsiblePerson.DrinkAndDrive());
        }

        [Fact]
        public void Proxy_Should_Not_Change_Results_According_To_Age()
        {
            // Arrange
            Person person = new() { Age = 18 };
            ResponsiblePerson responsiblePerson = new(person);

            // Act / Assert
            Assert.Equal(person.Drink(), responsiblePerson.Drink());
            Assert.Equal(person.Drive(), responsiblePerson.Drive());
        }

        [Fact]
        public void Proxy_Should_Never_Change_Results_With_Different_Ages()
        {
            // Arrange
            Person person1 = new() { Age = 1 };
            ResponsiblePerson responsiblePerson1 = new(person1);

            Person person2 = new() { Age = 111 };
            ResponsiblePerson responsiblePerson2 = new(person2);

            // Act / Assert
            Assert.Equal(person1.DrinkAndDrive(), person2.DrinkAndDrive());
        }
    }
}
