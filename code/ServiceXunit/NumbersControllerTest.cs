using Microsoft.AspNetCore.Mvc;
using Numbers.Controllers;
using System;
using Xunit;

namespace ServiceXunit
{
    public class NumbersControllerTest
    {
        [Fact]
        public void AddNumber_Test()
        {
            //Arrange
            var password = new NumbersController();
            //Act
            var controllerActionResult = new NumbersController();
            //Assert
            Assert.NotNull(controllerActionResult);
            Assert.NotNull("$%#@!*?()^&; :123456789");
            //hard
        }
 
        [Fact]
        public void Number_Test()
        {

            NumbersController numbersController = new NumbersController();
            var controllerActionResult = numbersController.Get();
            Assert.NotNull(controllerActionResult);
            Assert.IsType<ActionResult<string>>(controllerActionResult);
        }
    }
}
