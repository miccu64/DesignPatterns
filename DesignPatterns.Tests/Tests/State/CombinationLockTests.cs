using DesignPatterns.State;
using Xunit;

namespace DesignPatterns.Tests.Tests.State
{
    public class CombinationLockTests
    {

        [Fact]
        public void Should_Be_Locked_After_Init()
        {
            // Arrange / Act
            CombinationLock combinationLock = new([1]);

            // Assert
            Assert.Equal(CombinationLock.StatusLocked, combinationLock.Status);
        }

        [Fact]
        public void Should_Open_Lock_Returning_Correct_Value_After_Each_Digit()
        {
            // Arrange
            List<int> values = [1, 2, 3, 4, 5];
            CombinationLock combinationLock = new(values);

            // Act / Assert
            string joinedValues = "";
            for (int i = 0; i < values.Count; i++)
            {
                int value = values[i];
                combinationLock.EnterDigit(value);

                joinedValues += value;

                if (i < values.Count - 1)
                    Assert.Equal(joinedValues, combinationLock.Status);
            }

            Assert.Equal(CombinationLock.StatusOpen, combinationLock.Status);
        }

        [Fact]
        public void Should_Show_Error_When_Wrong_Code()
        {
            // Arrange
            List<int> values = [1, 2, 3];
            CombinationLock combinationLock = new(values);

            List<int> wrongValues = [1, 2, 4];

            // Act
            foreach (int value in wrongValues)
                combinationLock.EnterDigit(value);

            // Assert
            Assert.Equal(CombinationLock.StatusError, combinationLock.Status);
        }
    }
}
