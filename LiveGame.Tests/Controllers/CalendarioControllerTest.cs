using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LiveGame;
using LiveGame.Controllers;

namespace LiveGame.Tests.Controllers
{
    [TestClass]
    class CalendarioControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CalendarioController controller = new CalendarioController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
