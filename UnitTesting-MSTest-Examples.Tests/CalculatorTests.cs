using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTesting_MSTest_Examples.Tests
{
    /// <summary>
    /// Calculator tests class
    /// </summary>
    [TestClass()]
    public class CalculatorTests
    {
        /// <summary>
        /// Adds the test.
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            var calculator = new Calculator();
            int firstValue = 5;
            int secondValue = 6;
            int expectedValue = 20;

            //Act  
            int result = calculator.Add(firstValue, secondValue);

            //Assert  
            Assert.AreNotEqual(expectedValue, result);
        }

        /// <summary>
        /// Subtracts the test.
        /// </summary>
        [TestMethod]
        public void SubtractTest()
        {
            //Arrange
            var calculator = new Calculator();
            int firstValue = 3;
            int secondValue = 2;
            Exception expectedExcetpion = null;

            //Act              
            try
            {
                int result = calculator.Subtract(firstValue, secondValue);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            //Assert  
            Assert.IsNull(expectedExcetpion);
        }
    }
}