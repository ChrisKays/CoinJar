using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinJar.UnitTests
{
    [TestClass]
    public class CoinJarTest
    {
        [TestMethod]
        public void ShouldAddCoinIFVolumeIsLessThanCoinjarMaxVolumeTestMethod()
        {
            //Arrange
            var jar = new Controllers.CoinJarAPI();

            //Act
            var actual = jar.AddCoin(new Coin { Amount = 10, Volume = 40 });

            //Assert
            Assert.AreEqual("Coin Added to jar", actual);
        }

        [TestMethod]
        public void ShouldGetCoinjarTotalAmountTestMethod()
        {
            //Arrange
            var jar = new Controllers.CoinJarAPI();

            // act
            var result = jar.GetTotAmount();
            var okResult = result as OkObjectResult;

            // assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }
        [TestMethod]
        public void ShouldResetTestMethod()
        {
            //Arrange
            var jar = new Controllers.CoinJarAPI();

            //Act
            var actual = jar.ResetJar();
            var okResult = actual as OkObjectResult;

            //Assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }
    }
}
