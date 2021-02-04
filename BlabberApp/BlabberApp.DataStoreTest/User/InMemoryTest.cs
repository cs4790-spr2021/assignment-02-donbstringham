using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.DataStore;
using BlabberApp.Domain;

namespace BlabberApp.DataStoreTest
{
    [TestClass]
    public class UserEntityTest
    {
        [TestMethod]
        public void TestCanary()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestConstructorSuccess()
        {
            // arrange act
            var expected = new InMemory();
            var actual = new InMemory();
            // assert
            Assert.AreEqual(expected.Count(), actual.Count());
        }
        [TestMethod]
        public void TestConstructorFailure()
        {
            // arrange act
            var expected = new InMemory();
            var actual = new InMemory();
            // assert
            Assert.IsTrue(actual.Create(new UserEntity()));
            Assert.AreNotEqual(expected.Count(), actual.Count());
        }
        [TestMethod]
        public void TestConstructorOverrideSuccess()
        {
            // arrange
            UserEntity[] users = {
                new UserEntity(),
                new UserEntity(),
                new UserEntity()
            };
            var expected = 3;
            // act
            var fixture = new InMemory(users);
            var actual = fixture.Count();
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCountSuccess()
        {
            // arrange
            var expected = 1;
            var fixture = new InMemory();
            // act
            fixture.Create(new UserEntity());
            var actual = fixture.Count();
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
