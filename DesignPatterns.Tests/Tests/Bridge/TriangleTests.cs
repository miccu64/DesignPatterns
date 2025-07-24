using DesignPatterns.Bridge;
using Xunit;

namespace DesignPatterns.Tests.Tests.Bridge
{
    public class TriangleTests
    {
        [Fact]
        public void ToString_Should_Contain_Shape_Name()
        {
            // Arrange
            RasterRenderer renderer = new();
            Triangle triangle = new(renderer);

            // Act
            string result = triangle.ToString();

            // Assert
            Assert.Contains(triangle.Name, result);
        }

        [Fact]
        public void ToString_Should_Contain_Renderer_WhatToRenderAs()
        {
            // Arrange
            VectorRenderer renderer = new();
            Triangle triangle = new(renderer);

            // Act
            string result = triangle.ToString();

            // Assert
            Assert.Contains(renderer.WhatToRenderAs, result);
        }
    }
}
