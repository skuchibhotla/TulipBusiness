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
        }
    }
}
