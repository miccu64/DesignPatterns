using DesignPatterns.Builder;
using Xunit;

namespace DesignPatterns.Tests.Tests.Builder
{
    public class CodeBuilderTests
    {
        [Fact]
        public void Should_Create_Class_As_String()
        {
            // Act
            string classAsString = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int")
                .ToString();

            // Assert
            const string expectedResult = @"public class Person
{
  public string Name;
  public int Age;
}";
            Assert.Equal(expectedResult, classAsString);
        }
    }
}
