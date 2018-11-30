using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestApp.Controllers;

namespace UnitTestApp.Tests.Controllers
{
    [TestClass]
    public class StoreControllerTest
    {
        [TestMethod]
        public void IndexViewResultNotNull()
        {
            // Arrange
            StoreController storeController = new StoreController();

            // Act
            ViewResult result = storeController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMessage()
        {
            // Arrange
            StoreController storeController = new StoreController();

            // Act
            ViewResult result = storeController.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Another message", result.ViewBag.Message);
        }
    }
}
