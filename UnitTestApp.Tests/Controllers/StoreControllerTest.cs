using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestApp.Controllers;

namespace UnitTestApp.Tests.Controllers
{
    [TestClass]
    public class StoreControllerTest
    {
        private StoreController controller;
        private ViewResult result;

        // Initialize for all tests (if general context)
        [TestInitialize]
        public void SetupContext()
        {
            // Arrange
            controller = new StoreController();

            // Act
            result = controller.Index() as ViewResult;
        }

        [TestMethod]
        public void IndexViewResultNotNull()
        {
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void IndexViewEqualIndexCshtml()
        {
            // representation`s prop
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void TestMessage()
        {
            Assert.AreEqual("Hello world", result.ViewBag.Message);
        }
    }
}
