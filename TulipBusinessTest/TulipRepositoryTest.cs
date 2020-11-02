using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TulipBusiness;

namespace TulipBusinessTest
{
    [TestClass]
    public class TulipRepositoryTest
    {
        /// <summary>
        /// Procedure 1: Adding [ExpectedException(typeof(exception))] decorator
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestRepositoryTest_GetTulipMonthlySales_NotImplementedException_Procedure_1()
        {
            // Arrange
            TulipRepository _tulipRepositoryObj = new TulipRepository();

            // Act
            decimal result = _tulipRepositoryObj.GetTulipMonthlySales(4, 2015);

            // Assert
        }

        /// <summary>
        /// Procedure 2: Adding try-catch to get the exception, and asserting to see the type.
        /// </summary>
        [TestMethod]
        public void TestRepositoryTest_GetTulipMonthlySales_NotImplementedException_Procedure_2()
        {
            // Arrange
            Exception expectedException = null;
            TulipRepository _tulipRepositoryObj = new TulipRepository();

            // Act
            try
            {
                // This will give out an exception. 
                decimal result = _tulipRepositoryObj.GetTulipMonthlySales(4, 2015);
            }
            catch(Exception ex)
            {
                expectedException = ex;
            }

            // Assert
            Assert.IsNotNull(expectedException);
            Assert.IsInstanceOfType(expectedException, typeof(NotImplementedException));
        }
    }
}
