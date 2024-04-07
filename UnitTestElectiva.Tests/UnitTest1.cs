using System;
using Xunit;
using SimpleWebApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ContentResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Hello, World!", result.Content);
        }
    }
}
