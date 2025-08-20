using DesignPatterns.Iterator;
using Xunit;

namespace DesignPatterns.Tests.Tests.Iterator
{
    public class NodeTests
    {
        [Fact]
        public void Should_Iterate_Binary_Tree_In_Preorder()
        {
            // Arrange
            Node<string> c = new("c");
            Node<string> e = new("e");

            Node<string> d = new("d", c, e);
            Node<string> a = new("a");

            Node<string> b = new("b", a, d);

            Node<string> h = new("h");

            Node<string> i = new("i", h, null);

            Node<string> g = new("g", null, i);

            Node<string> f = new("f", b, g);

            // Act
            string result = "";
            foreach (string value in f.PreOrder)
                result += value;

            // Assert
            const string expectedResult = "fbadcegih";
            Assert.Equal(expectedResult, result);
        }
    }
}
