using System;
using System.Collections.Generic;
using System.Text;
using Mishanya.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace TestProject1
{
    public class HomeControllerTests
    {
        private string currentType;

        [Test]
        public void IndexViewDataMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index(currentType) as ViewResult;

            // Assert
            Assert.Equals("Hello world!", result?.ViewData["Message"]);
        }

        /*[Fact]
        public void IndexViewResultNotNull()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void IndexViewNameEqualIndex()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.Equal("Index", result?.ViewName);
        }*/
    }
}
