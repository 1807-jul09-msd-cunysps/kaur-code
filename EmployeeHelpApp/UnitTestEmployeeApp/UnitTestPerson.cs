using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;

namespace UnitTestEmployeeApp
{
    [TestClass]//Decorators/Annotations/Attributes
    public class UnitTestPerson
    {
        [TestMethod]
        public void TestMethodGetPassword()
        {
            //Arrange
            Employee emp = new Employee();
            string firstName = "john    ";
            long ssn = 7894561;
            string expectedValue = "1654987nhoj";
            string actualValue = "";
            //Act
            actualValue=  emp.GetPassword(ssn:ssn,firstName:firstName);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}
