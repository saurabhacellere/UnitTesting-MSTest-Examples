using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest_Examples.Tests
{
    /// <summary>
    /// Employee tests class
    /// </summary>
    [TestClass()]
    public class EmployeeTests
    {
        /// <summary>
        /// Gets the name test.
        /// </summary>
        [TestMethod()]
        public void GetNameTest()
        {
            //Arrange  
            Employee employee = new Employee();
            string firstName = "Peter";
            string lastName = "Bravo";
            string expected = "Peter Bravo";
            string actual;

            //Act  
            actual = employee.GetName(firstName, lastName);
            
            //Assert  
            Assert.AreEqual(expected, actual);
        }
    }
}