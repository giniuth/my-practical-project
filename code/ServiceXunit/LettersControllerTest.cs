using Letters.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ServiceXunit
{

    public class LettersControllerTest
    {
        private LettersController lettersController;
        public LettersControllerTest()
        {
            lettersController = new LettersController();

        }
        [Fact]
        public void AddLetter_Test()
        {
            //Arrange
            //var password = new LettersController();
            
            //Act
           var controllerActionResult = lettersController.Get();
            
            //Assert
            Assert.NotNull(controllerActionResult);
        }
    }
}
