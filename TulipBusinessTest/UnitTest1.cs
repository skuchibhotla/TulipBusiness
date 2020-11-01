using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TulipBusiness;

namespace TulipBusinessTest
{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void GetTulipSales_2014()
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
    }
}
