using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void TestInvalidID()
        {
            // arrange
            var harness = new User();
            var expected = "foobar";
            // act assert
            Assert.ThrowsException<FormatException>(() => harness.setID(expected));
        }
    }
}
