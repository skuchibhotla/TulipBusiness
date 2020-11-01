using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TulipBusiness;

namespace TulipBusinessTest
{
    [TestClass]
    public class TulipBusinessTest
    { 
        [TestMethod]
        public void TulipBusinessTest_GetTulipAnnualSales_2014()
        {
            // Arrange
            var tulipRepositoryMock = new Mock<ITulipRepository>();
            tulipRepositoryMock.Setup(t => t.GetTulipYearSales(2014)).Returns(1050.0M);
            TulipBusinessClass tulipBusinessObj = new TulipBusinessClass(tulipRepositoryMock.Object);

            // Act
            decimal tulipAnnualSales2014 = tulipBusinessObj.GetTulipAnnualSales(2014);

            // Assert
            Assert.AreEqual(tulipAnnualSales2014, 1050M);
            tulipRepositoryMock.Verify(t => t.GetTulipYearSales(2014), Times.Once);
        }

        [TestMethod]
        public void TulipBusinessTest_GetTulipAnnualSales_2015()
        {
            // Arrange
            var tulipRespositoryMock = new Mock<ITulipRepository>();
            tulipRespositoryMock.Setup(x => x.GetTulipYearSales(2015)).Returns(1500.2M);
            TulipBusinessClass tulipBusinessClassObj = new TulipBusinessClass(tulipRespositoryMock.Object);

            // Act
            decimal tulipSalesFor2015 = tulipBusinessClassObj.GetTulipAnnualSales(2015);

            // Assert
            Assert.AreEqual(tulipSalesFor2015, 1500.2M);
            tulipRespositoryMock.Verify(t => t.GetTulipYearSales(2015), Times.Once);
        }

        [TestMethod]
        public void TulipBusinessTest_GetTulipMonthlySales_April_2014()
        {
            // Arrange
            var _tulipRepositoryMock = new Mock<ITulipRepository>();
            _tulipRepositoryMock.Setup(x => x.GetTulipMonthlySales(4, 2014)).Returns(0.21M);
            TulipBusinessClass _tulipBusinessClassObj = new TulipBusinessClass(_tulipRepositoryMock.Object);

            // Act
            decimal result = _tulipBusinessClassObj.GetTulipMonthlySales(4, 2014);

            // Assert
            Assert.AreEqual(result, 0.21M);
        }

        [TestMethod]
        public void TulipBUsinessTest_GetTulipSales_GenericTest()
        {
            // Arrange
            var _tulipRepositoryMock = new Mock<ITulipRepository>();
            _tulipRepositoryMock.Setup(x => x.GetTulipMonthlySales(It.IsAny<int>(), It.IsAny<int>())).Returns(0.10M);
            TulipBusinessClass _tulipBusinessClassObj = new TulipBusinessClass(_tulipRepositoryMock.Object);

            // Act
            decimal result = _tulipBusinessClassObj.GetTulipMonthlySales(It.IsAny<int>(), It.IsAny<int>());

            // Assert
            Assert.AreEqual(result, 0.10M);

            // Checking if the types are not exactly the same. 
            Assert.AreEqual(result.GetType(), typeof(decimal));

            // Checking if result is not assignable to the given type. Usually works with user-created types/objects. 
            Assert.IsInstanceOfType(result, typeof(decimal));
        }
    }
}
