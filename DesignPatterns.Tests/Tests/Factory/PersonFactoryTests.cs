using DesignPatterns.Factory;
using DesignPatterns.Factory.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Factory
{
    public class PersonFactoryTests
    {
        [Fact]
        public void Should_Create_Person_With_Id_0()
        {
            // Arrange
            const string name = "name";
            PersonFactory personFactory = new();

            // Act
            Person person = personFactory.CreatePerson(name);

            // Assert
            Assert.NotNull(person);
            Assert.Equal(name, person.Name);
            Assert.Equal(0, person.Id);
        }

        [Fact]
        public void Should_Create_Persons_With_Subsequent_Ids()
        {
            // Arrange
            const int startId = 0;
            const int personsCount = 10;
            PersonFactory personFactory = new();
            List<Person> persons = [];

            // Act
            for (int i = startId; i < personsCount; i++)
                persons.Add(personFactory.CreatePerson(i.ToString()));

            // Assert
            for (int i = startId; i < personsCount; i++)
                Assert.Equal(i, persons[i].Id);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Should_Throw_On_Null_Empty_Whitespace_Name(string? name)
        {
            // Arrange
            PersonFactory personFactory = new();

            // Act / Assert
            Assert.ThrowsAny<ArgumentException>(() => personFactory.CreatePerson(name));
        }
    }
}
