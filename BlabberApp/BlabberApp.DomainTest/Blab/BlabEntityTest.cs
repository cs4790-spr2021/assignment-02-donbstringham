using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class BlabEntityTest
    {
        [TestMethod]
        public void TestCanary()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestConstructorArgument()
        {
            // arrange
            var fixture = new BlabEntity("foobar");
            var expected = "foobar";
            // act
            var actual = fixture.Msg;
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}