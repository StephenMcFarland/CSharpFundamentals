using System;
using _03_Class_Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Class_Example_Tests
{
    [TestClass]
    public class Cookie_Tests
    {
        [TestMethod]
        public void MakingACookie()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.BatchSize = 60;
            cookie.GlutenFree = true;

            Cookie chocolateCookie = new Cookie();
            chocolateCookie.Name = "chocolate chip cookie";
            chocolateCookie.BatchSize = 40;
            chocolateCookie.GlutenFree = false;

            Assert.AreEqual("Snickerdoodle", cookie.Name);
            Assert.AreEqual(60, cookie.BatchSize);
            Assert.AreEqual(true, cookie.GlutenFree);

            Assert.AreEqual("chocolate chip cookie", chocolateCookie.Name);
            Assert.AreEqual(40, chocolateCookie.BatchSize);
            Assert.AreEqual(false, chocolateCookie.GlutenFree);
        }
    }
}
