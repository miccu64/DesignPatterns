using DesignPatterns.Singleton;
using Xunit;

namespace DesignPatterns.Tests.Tests.Singleton
{
    public class SingletonTesterTests
    {
        [Fact]
        public void Should_Return_True_On_Singleton()
        {
            // Arrange
            Func<object> singletonFactory = () => TestSingleton.Instance;

            // Act
            bool isSingleton = SingletonTester.IsSingleton(singletonFactory);
        
            // Assert
            Assert.True(isSingleton);
        }

        [Fact]
        public void Should_Return_False_On_Same_Instance_Of_Regular_Class()
        {
            // Arrange
            Func<object> factory = () => new SingletonTesterTests();

            // Act
            bool isSingleton = SingletonTester.IsSingleton(factory);

            // Assert
            Assert.False(isSingleton);
        }

        private sealed class TestSingleton
        {
            private static readonly Lazy<TestSingleton> _instance = new(() => new TestSingleton());

            public static TestSingleton Instance => _instance.Value;

            private TestSingleton() { }
        }
    }
}
