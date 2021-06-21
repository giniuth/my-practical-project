using Merge;
using Merge.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using System.Diagnostics.CodeAnalysis;
using Xunit;

namespace ServiceXunit
{
    //[ExcludeFromCodeCoverage]
    public class MergeControllerTest
    {
        private AppSettings appSettings = new AppSettings()
        {
            numbersServiceURL = "https://gini-app-service.azurewebsites.net",
            lettersServiceURL = "https://gini-app-service2.azurewebsites.net"
        };
        [Fact]
        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeContollerResult = await mergeController.Get();

            Assert.NotNull(mergeContollerResult);
            Assert.IsType<OkObjectResult>(mergeContollerResult);
        }
    }
}

